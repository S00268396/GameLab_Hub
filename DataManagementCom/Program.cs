using GameLab_Hub;
using System;

namespace DataManagementCom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComputerData db = new ComputerData();

            using (db)
            {
                Computer c1 = new Computer { ComputerID = 1, SotferwareInstalled = "Adobe Photoshop" };

                Computer_Lab cl1 = new Computer_Lab { Computer_LabID = 1, Location = "Building 3", IsAvailable = true };

                Exam_Lab el1 = new Exam_Lab { Exam_LabID = 1, CourseName = "Math 101", TypeOfExam = "Final", DateOfExam = new DateTime(2024, 12, 15), TeacherName = "Dr. Smith", Location = "Building 3" };

                db.Computers.Add(c1);
                db.Computer_Labs.Add(cl1);
                db.Exam_Labs.Add(el1);
                db.SaveChanges();
            }

        }
    }
}
