using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace WpfApp1
{
    public class Computer
    {
        public int ComputerID { get; set; }
        public string SoftwareInstalled { get; set; }  //changed typo

        public int Computer_LabID { get; set; }  //explicitly added foreign key property
        public virtual Computer_Lab ComputerLab { get; set; }
    }


    //old one - using this one for now March 18
    public class Computer_Lab
    {
        public int Computer_LabID { get; set; }
        public string Location { get; set; }
        public bool IsAvailable { get; set; }

        public virtual List<Computer> Computers { get; set; }

        public virtual List<Exam_Lab> ExamLabs { get; set; }  //added navigation property for one-to-many relationship


        public Computer_Lab()
        {
            Computers = new List<Computer>();
            ExamLabs = new List<Exam_Lab>();  //initialize the list to avoid null reference issues
        }
    }

    public class Exam_Lab
    {
        public int Exam_LabID { get; set; }
        public string CourseName { get; set; }
        public string YearGroup { get; set; }
        public string TypeOfExam { get; set; }
        public string Semester { get; set; }
        public DateTime DateOfExam { get; set; }       
        public string LongOfTime { get; set; }
        public string TeacherName { get; set; }
        public virtual List<Computer_Lab> ComputerLabs { get; set; }
        public Exam_Lab()
        {
            ComputerLabs = new List<Computer_Lab>();  //initialize the list to avoid null reference issues
        }

    }

    public class ComputerData : DbContext
    {
        public ComputerData() : base("MyComputerData") { }

        public DbSet<Computer> Computers { get; set; }
        public DbSet<Computer_Lab> Computer_Labs { get; set; }
        public DbSet<Exam_Lab> Exam_Labs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Explicit FK for Computer -> Computer_Lab
            modelBuilder.Entity<Computer>()
                .HasRequired(c => c.ComputerLab)
                .WithMany(l => l.Computers)
                .HasForeignKey(c => c.Computer_LabID);

            // Many-to-many: Exam_Lab <-> Computer_Lab
            // EF6 will create a junction table automatically
            modelBuilder.Entity<Exam_Lab>()
                .HasMany(e => e.ComputerLabs)
                .WithMany(l => l.ExamLabs)
                .Map(m =>
                {
                    m.ToTable("Exam_Lab_Computer_Lab");
                    m.MapLeftKey("Exam_LabID");
                    m.MapRightKey("Computer_LabID");
                });
        }
    }
}
