using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLab_Hub
{
    public class Computer
    {
        public int ComputerID { get; set; }
        public string SotferwareInstalled { get; set; }
        public virtual Computer_Lab ComputerLab { get; set; }
    }


    //new one
    public class Computer_Lab
    {
        public int Computer_LabID { get; set; }
        public string Location { get; set; }
        public bool IsAvailable { get; set; }

        public virtual List<Computer> Computers { get; set; } 

        public int ComputerID { get; set; }
        public virtual Exam_Lab ExamLab { get; set; }

        public Computer_Lab()
        {
            Computers = new List<Computer>();
        }
    } 

    public class Exam_Lab
    {
        public int Exam_LabID { get; set; }
        public string CourseName { get; set; }
        public string TypeOfExam { get; set; }
        public DateTime DateOfExam { get; set; }
        public string TeacherName { get; set; }
        public int Computer_LabID { get; set; }
        public virtual Computer_Lab ComputerLab { get; set; }

    }

    public class ComputerData : DbContext
    {
        public ComputerData() : base("MyComputerData") { }

        public DbSet<Computer> Computers { get; set; }
       public DbSet<Computer_Lab> Computer_Labs { get; set; }
       public DbSet<Exam_Lab> Exam_Labs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Computer_Lab>()
                .HasOptional(c => c.ExamLab)
                .WithRequired(c => c.ComputerLab);

        }
    }
}
