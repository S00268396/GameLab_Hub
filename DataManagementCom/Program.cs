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
                //Computers: 21 to 29  is in the start of the ComputerID 
                Computer c1 = new Computer { ComputerID = 211, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio"};
                Computer c2 = new Computer { ComputerID = 212, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c3 = new Computer { ComputerID = 213, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c4 = new Computer { ComputerID = 214, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c5 = new Computer { ComputerID = 215, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c6 = new Computer { ComputerID = 216, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c7 = new Computer { ComputerID = 217, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c8 = new Computer { ComputerID = 218, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c9 = new Computer { ComputerID = 219, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c10 = new Computer { ComputerID = 220, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c11 = new Computer { ComputerID = 221, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c12 = new Computer { ComputerID = 222, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c13 = new Computer { ComputerID = 223, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c14 = new Computer { ComputerID = 224, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c15 = new Computer { ComputerID = 225, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c16 = new Computer { ComputerID = 226, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c17 = new Computer { ComputerID = 227, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c18 = new Computer { ComputerID = 228, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c19 = new Computer { ComputerID = 229, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c20 = new Computer { ComputerID = 230, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c21 = new Computer { ComputerID = 231, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c22 = new Computer { ComputerID = 232, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c23 = new Computer { ComputerID = 233, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c24 = new Computer { ComputerID = 234, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c25 = new Computer { ComputerID = 235, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c26 = new Computer { ComputerID = 236, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c27 = new Computer { ComputerID = 237, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c28 = new Computer { ComputerID = 238, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c29 = new Computer { ComputerID = 239, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c30 = new Computer { ComputerID = 240, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c31 = new Computer { ComputerID = 241, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c32 = new Computer { ComputerID = 242, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c33 = new Computer { ComputerID = 243, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c34 = new Computer { ComputerID = 244, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c35 = new Computer { ComputerID = 245, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c36 = new Computer { ComputerID = 246, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c37 = new Computer { ComputerID = 247, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c38 = new Computer { ComputerID = 248, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c39 = new Computer { ComputerID = 249, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c40 = new Computer { ComputerID = 250, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c41 = new Computer { ComputerID = 251, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c42 = new Computer { ComputerID = 252, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c43 = new Computer { ComputerID = 253, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c44 = new Computer { ComputerID = 254, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c45 = new Computer { ComputerID = 255, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c46 = new Computer { ComputerID = 256, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c47 = new Computer { ComputerID = 257, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c48 = new Computer { ComputerID = 258, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c49 = new Computer { ComputerID = 259, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c50 = new Computer { ComputerID = 260, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c51 = new Computer { ComputerID = 261, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c52 = new Computer { ComputerID = 262, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c53 = new Computer { ComputerID = 263, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c54 = new Computer { ComputerID = 264, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c55 = new Computer { ComputerID = 266, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c56 = new Computer { ComputerID = 267, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c57 = new Computer { ComputerID = 268, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c58 = new Computer { ComputerID = 269, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c59 = new Computer { ComputerID = 280, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c60 = new Computer { ComputerID = 281, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c61 = new Computer { ComputerID = 282, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c62 = new Computer { ComputerID = 283, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c63 = new Computer { ComputerID = 284, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c64 = new Computer { ComputerID = 285, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c65 = new Computer { ComputerID = 286, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c66 = new Computer { ComputerID = 287, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c67 = new Computer { ComputerID = 288, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c68 = new Computer { ComputerID = 289, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c69 = new Computer { ComputerID = 290, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c70 = new Computer { ComputerID = 291, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c71 = new Computer { ComputerID = 292, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c72 = new Computer { ComputerID = 293, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c73 = new Computer { ComputerID = 294, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                //Computer c74 = new Computer { ComputerID = 295, SotferwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
               


                //Labs: 36 to 38 is in the start of the Computer_LabID 
                Computer_Lab cl1 = new Computer_Lab() { Computer_LabID = 361, Location = "B Block", IsAvailable = false };
                Computer_Lab cl2 = new Computer_Lab (){ Computer_LabID = 362, Location = "B Block", IsAvailable = true };
                Computer_Lab cl3 = new Computer_Lab (){ Computer_LabID = 363, Location = "B Block", IsAvailable = false };
                //Computer_Lab cl4 = new Computer_Lab { Computer_LabID = 364, Location = "A Block", IsAvailable = true };
                //Computer_Lab cl5 = new Computer_Lab { Computer_LabID = 365, Location = "A Block", IsAvailable = false };
                //Computer_Lab cl6 = new Computer_Lab { Computer_LabID = 366, Location = "A Block", IsAvailable = true };
                //Computer_Lab cl7 = new Computer_Lab { Computer_LabID = 367, Location = "C Block", IsAvailable = false };
                //Computer_Lab cl8 = new Computer_Lab { Computer_LabID = 368, Location = "C Block", IsAvailable = true };
                //Computer_Lab cl9 = new Computer_Lab { Computer_LabID = 369, Location = "C Block", IsAvailable = false };
                //Computer_Lab cl10 = new Computer_Lab { Computer_LabID = 361, Location = "B Block", IsAvailable = false };
                //Computer_Lab cl11 = new Computer_Lab { Computer_LabID = 362, Location = "B Block", IsAvailable = true };
                //Computer_Lab cl12 = new Computer_Lab { Computer_LabID = 363, Location = "B Block", IsAvailable = false };
                //Computer_Lab cl13 = new Computer_Lab { Computer_LabID = 364, Location = "A Block", IsAvailable = true };
                //Computer_Lab cl14 = new Computer_Lab { Computer_LabID = 365, Location = "A Block", IsAvailable = false };
                //Computer_Lab cl15 = new Computer_Lab { Computer_LabID = 366, Location = "A Block", IsAvailable = true };
                //Computer_Lab cl16 = new Computer_Lab { Computer_LabID = 367, Location = "C Block", IsAvailable = false };
                //Computer_Lab cl17 = new Computer_Lab { Computer_LabID = 368, Location = "C Block", IsAvailable = true };
                //Computer_Lab cl18 = new Computer_Lab { Computer_LabID = 368, Location = "C Block", IsAvailable = true };
                //Computer_Lab cl19 = new Computer_Lab { Computer_LabID = 369, Location = "B Block", IsAvailable = false };
                //Computer_Lab cl20 = new Computer_Lab { Computer_LabID = 370, Location = "B Block", IsAvailable = true };
                //Computer_Lab cl21 = new Computer_Lab { Computer_LabID = 371, Location = "B Block", IsAvailable = false };
                //Computer_Lab cl22 = new Computer_Lab { Computer_LabID = 372, Location = "A Block", IsAvailable = true };
                //Computer_Lab cl23 = new Computer_Lab { Computer_LabID = 373, Location = "A Block", IsAvailable = false };
                //Computer_Lab cl24 = new Computer_Lab { Computer_LabID = 374, Location = "A Block", IsAvailable = true };
                //Computer_Lab cl25 = new Computer_Lab { Computer_LabID = 375, Location = "C Block", IsAvailable = false };
                //Computer_Lab cl26 = new Computer_Lab { Computer_LabID = 376, Location = "C Block", IsAvailable = true };
                //Computer_Lab cl27 = new Computer_Lab { Computer_LabID = 377, Location = "C Block", IsAvailable = false };
                //Computer_Lab cl28 = new Computer_Lab { Computer_LabID = 378, Location = "B Block", IsAvailable = false };
                //Computer_Lab cl39 = new Computer_Lab { Computer_LabID = 379, Location = "B Block", IsAvailable = true };
                //Computer_Lab cl30 = new Computer_Lab { Computer_LabID = 380, Location = "B Block", IsAvailable = false };
                //Computer_Lab cl31 = new Computer_Lab { Computer_LabID = 381, Location = "A Block", IsAvailable = true };
                //Computer_Lab cl32 = new Computer_Lab { Computer_LabID = 382, Location = "A Block", IsAvailable = false };
                //Computer_Lab cl33 = new Computer_Lab { Computer_LabID = 383, Location = "A Block", IsAvailable = true };
                //Computer_Lab cl34 = new Computer_Lab { Computer_LabID = 384, Location = "C Block", IsAvailable = false };
                //Computer_Lab cl35 = new Computer_Lab { Computer_LabID = 385, Location = "C Block", IsAvailable = true };
                //Computer_Lab cl36 = new Computer_Lab { Computer_LabID = 385, Location = "C Block", IsAvailable = true };



                //Exam: 94 is in the start of the Computer_LabID 
                Exam_Lab el1 = new Exam_Lab { Exam_LabID = 941, CourseName = "Games Development L7 - Y2",   TypeOfExam = "3D Game Programming",             DateOfExam = new DateTime(2024, 12, 15), TeacherName = "Neil Gannon",       Location = "B Block" };
                //Exam_Lab el2 = new Exam_Lab { Exam_LabID = 942, CourseName = "Games Development L7 - Y3",   TypeOfExam = "Math 3",                          DateOfExam = new DateTime(2024, 12, 15), TeacherName = "Kieran Hughes",     Location = "B Block" };
                //Exam_Lab el3 = new Exam_Lab { Exam_LabID = 943, CourseName = "Games Development L7 - Y1",   TypeOfExam = "Object Oriented Development",     DateOfExam = new DateTime(2024, 12, 15), TeacherName = "Keith McManus",     Location = "B Block" };
                //Exam_Lab el4 = new Exam_Lab { Exam_LabID = 944, CourseName = "Games Development L6 - Y2",   TypeOfExam = "Software Quality and Testing",    DateOfExam = new DateTime(2024, 12, 15), TeacherName = "Vivion Kinsella",   Location = "A Block" };
                //Exam_Lab el5 = new Exam_Lab { Exam_LabID = 945, CourseName = "Games Development L6 - Y1",   TypeOfExam = "Math 1",                          DateOfExam = new DateTime(2024, 12, 15), TeacherName = "Kieran Hughes",     Location = "A Block" };
                //Exam_Lab el6 = new Exam_Lab { Exam_LabID = 946, CourseName = "Games Development L8 - Y1",   TypeOfExam = "Software Quality and Testing ",   DateOfExam = new DateTime(2024, 12, 15), TeacherName = "Vivion Kinsella",   Location = "A Block" };
                //Exam_Lab el7 = new Exam_Lab { Exam_LabID = 947, CourseName = "Games Development L8 - Y2",   TypeOfExam = "Object Oriented Development",     DateOfExam = new DateTime(2024, 12, 15), TeacherName = "Keith McManus",     Location = "C Block" };
                //Exam_Lab el8 = new Exam_Lab { Exam_LabID = 948, CourseName = "Games Development L8 - Y3",   TypeOfExam = "Software Quality and Testing",    DateOfExam = new DateTime(2024, 12, 15), TeacherName = "Vivion Kinsella",   Location = "C Block" };
                //Exam_Lab el9 = new Exam_Lab { Exam_LabID = 949, CourseName = "Games Development L8 - Y4",   TypeOfExam = "3D Game Programming",             DateOfExam = new DateTime(2024, 12, 15), TeacherName = "Neil Gannon",       Location = "C Block" };

                //Add the Computers into the Labs
                cl1.Computers.Add(c1);
                cl1.Computers.Add(c2);   
                cl1.Computers.Add(c3);
                //cl2.Computers.Add(c4);
                //cl2.Computers.Add(c5);
                //cl2.Computers.Add(c6);
                //cl3.Computers.Add(c7);
                //cl3.Computers.Add(c8); 
                //cl3.Computers.Add(c9);
                //cl4.Computers.Add(c10);
                //cl4.Computers.Add(c11);
                //cl4.Computers.Add(c12);
                //cl5.Computers.Add(c13);
                //cl5.Computers.Add(c14);
                //cl5.Computers.Add(c15);
                //cl6.Computers.Add(c16);
                //cl6.Computers.Add(c17);
                //cl6.Computers.Add(c18);
                //cl7.Computers.Add(c19);
                //cl7.Computers.Add(c20);
                //cl7.Computers.Add(c21);
                //cl8.Computers.Add(c22);
                //cl8.Computers.Add(c23);
                //cl8.Computers.Add(c24);
                //cl9.Computers.Add(c25);
                //cl9.Computers.Add(c26);
                //cl9.Computers.Add(c27);
                //cl10.Computers.Add(c28);
                //cl10.Computers.Add(c29);
                //cl10.Computers.Add(c30);
                //cl11.Computers.Add(c31);
                //cl11.Computers.Add(c32);
                //cl11.Computers.Add(c33);
                //cl12.Computers.Add(c34);
                //cl12.Computers.Add(c35);
                //cl12.Computers.Add(c36);
                //cl13.Computers.Add(c37);
                //cl13.Computers.Add(c38);
                //cl13.Computers.Add(c39);
                //cl14.Computers.Add(c40);
                //cl14.Computers.Add(c41);
                //cl14.Computers.Add(c42);
                //cl15.Computers.Add(c43);
                //cl15.Computers.Add(c44);
                //cl15.Computers.Add(c45);
                //cl16.Computers.Add(c46);
                //cl16.Computers.Add(c47);
                //cl16.Computers.Add(c48);
                //cl17.Computers.Add(c49);
                //cl17.Computers.Add(c50);
                //cl17.Computers.Add(c51);
                //cl18.Computers.Add(c52);
                //cl18.Computers.Add(c53);
                //cl18.Computers.Add(c54);
                //cl19.Computers.Add(c56);
                //cl19.Computers.Add(c57);
                //cl19.Computers.Add(c58);
                //cl20.Computers.Add(c59);
                //cl20.Computers.Add(c60);
                //cl20.Computers.Add(c61);
                //cl21.Computers.Add(c62);
                //cl21.Computers.Add(c63);
                //cl21.Computers.Add(c64);
                //cl22.Computers.Add(c65);
                //cl22.Computers.Add(c66);
                //cl22.Computers.Add(c67);
                //cl23.Computers.Add(c68);
                //cl23.Computers.Add(c69);
                //cl23.Computers.Add(c70);
                //cl24.Computers.Add(c71);
                //cl24.Computers.Add(c72);
                //cl24.Computers.Add(c73);


                //Add the Labs into the Exam_labs
                el1.ComputerLabs.Add(cl1);
                el1.ComputerLabs.Add(cl2);
                el1.ComputerLabs.Add(cl3);
                //el2.ComputerLab = cl4;
                //el2.ComputerLab = cl5;
                //el2.ComputerLab = cl6;
                //el3.ComputerLab = cl7;
                //el3.ComputerLab = cl8;
                //el3.ComputerLab = cl9;
                //el4.ComputerLab = cl10;
                //el4.ComputerLab = cl11;
                //el4.ComputerLab = cl12;
                //el5.ComputerLab = cl13;
                //el5.ComputerLab = cl14;
                //el5.ComputerLab = cl15;
                //el6.ComputerLab = cl16;
                //el6.ComputerLab = cl17;
                //el6.ComputerLab = cl18;
                //el7.ComputerLab = cl19;
                //el7.ComputerLab = cl20;
                //el7.ComputerLab = cl21;
                //el8.ComputerLab = cl22;
                //el8.ComputerLab = cl23;
                //el8.ComputerLab = cl24;


                //Add the Labs
                db.Computer_Labs.Add(cl1);
                db.Computer_Labs.Add(cl2);
                db.Computer_Labs.Add(cl3);
                //db.Computer_Labs.Add(cl4);
                //db.Computer_Labs.Add(cl5);
                //db.Computer_Labs.Add(cl6);
                //db.Computer_Labs.Add(cl7);
                //db.Computer_Labs.Add(cl8);
                //db.Computer_Labs.Add(cl9);
             
                //Add the Exam_Labs
                db.Exam_Labs.Add(el1);
                //db.Exam_Labs.Add(el2);
                //db.Exam_Labs.Add(el3);
                //db.Exam_Labs.Add(el4);
                //db.Exam_Labs.Add(el5);
                //db.Exam_Labs.Add(el6);
                //db.Exam_Labs.Add(el7);
                //db.Exam_Labs.Add(el8);
                //db.Exam_Labs.Add(el9);

                db.SaveChanges();
            }

        }
    }
}
