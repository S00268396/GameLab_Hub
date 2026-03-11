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
                //Computers
                Computer c1 = new Computer { ComputerID = 1, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c2 = new Computer { ComputerID = 2, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c3 = new Computer { ComputerID = 3, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c4 = new Computer { ComputerID = 4, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c5 = new Computer { ComputerID = 5, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c6 = new Computer { ComputerID = 6, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c7 = new Computer { ComputerID = 7, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c8 = new Computer { ComputerID = 8, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c9 = new Computer { ComputerID = 9, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };

                //Labs
                Computer_Lab cl1 = new Computer_Lab { Computer_LabID = 1, Location = "B Block ", IsAvailable = true };
                Computer_Lab cl2 = new Computer_Lab { Computer_LabID = 2, Location = "Building 3", IsAvailable = true };
                Computer_Lab cl3 = new Computer_Lab { Computer_LabID = 3, Location = "Building 3", IsAvailable = true };
                Computer_Lab cl4 = new Computer_Lab { Computer_LabID = 4, Location = "Building 3", IsAvailable = true };
                Computer_Lab cl5 = new Computer_Lab { Computer_LabID = 5, Location = "Building 3", IsAvailable = true };
                Computer_Lab cl6 = new Computer_Lab { Computer_LabID = 6, Location = "Building 3", IsAvailable = true };
                Computer_Lab cl7 = new Computer_Lab { Computer_LabID = 7, Location = "Building 3", IsAvailable = true };
                Computer_Lab cl8 = new Computer_Lab { Computer_LabID = 8, Location = "Building 3", IsAvailable = true };
                Computer_Lab cl9 = new Computer_Lab { Computer_LabID = 9, Location = "Building 3", IsAvailable = true };


                Exam_Lab el1 = new Exam_Lab { Exam_LabID = 1, CourseName = "Math 101", TypeOfExam = "Final", DateOfExam = new DateTime(2024, 12, 15), TeacherName = "Dr. Smith", Location = "Building 3" };

                db.Computers.Add(c1);
                db.Computer_Labs.Add(cl1);
                db.Exam_Labs.Add(el1);
                db.SaveChanges();
            }

        }
    }
}
