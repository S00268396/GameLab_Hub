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
                Computer c1 = new Computer  {ComputerID = 211, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c2 = new Computer  {ComputerID = 212, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c3 = new Computer  {ComputerID = 213, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c4 = new Computer  {ComputerID = 214, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c5 = new Computer  {ComputerID = 215, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c6 = new Computer  {ComputerID = 216, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c7 = new Computer  {ComputerID = 217, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c8 = new Computer  {ComputerID = 218, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c9 = new Computer  {ComputerID = 219, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c10 = new Computer {ComputerID = 220, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c11 = new Computer {ComputerID = 221, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c12 = new Computer {ComputerID = 222, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c13 = new Computer {ComputerID = 223, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c14 = new Computer {ComputerID = 224, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c15 = new Computer {ComputerID = 225, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c16 = new Computer {ComputerID = 226, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c17 = new Computer {ComputerID = 227, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c18 = new Computer {ComputerID = 228, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c19 = new Computer {ComputerID = 229, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c20 = new Computer {ComputerID = 230, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c21 = new Computer {ComputerID = 231, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c22 = new Computer {ComputerID = 232, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c23 = new Computer {ComputerID = 233, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c24 = new Computer {ComputerID = 234, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c25 = new Computer {ComputerID = 235, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c26 = new Computer {ComputerID = 236, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c27 = new Computer {ComputerID = 237, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c28 = new Computer {ComputerID = 238, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c29 = new Computer {ComputerID = 239, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c30 = new Computer {ComputerID = 240, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c31 = new Computer {ComputerID = 241, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c32 = new Computer {ComputerID = 242, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c33 = new Computer {ComputerID = 243, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c34 = new Computer {ComputerID = 244, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c35 = new Computer {ComputerID = 245, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c36 = new Computer {ComputerID = 246, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c37 = new Computer {ComputerID = 247, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c38 = new Computer {ComputerID = 248, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c39 = new Computer {ComputerID = 249, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c40 = new Computer {ComputerID = 250, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c41 = new Computer {ComputerID = 251, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c42 = new Computer {ComputerID = 252, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c43 = new Computer {ComputerID = 253, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c44 = new Computer {ComputerID = 254, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c45 = new Computer {ComputerID = 255, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c46 = new Computer {ComputerID = 256, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c47 = new Computer {ComputerID = 257, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c48 = new Computer {ComputerID = 258, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c49 = new Computer {ComputerID = 259, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c50 = new Computer {ComputerID = 260, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c51 = new Computer {ComputerID = 261, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c52 = new Computer {ComputerID = 262, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c53 = new Computer {ComputerID = 263, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c54 = new Computer {ComputerID = 264, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c55 = new Computer {ComputerID = 266, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c56 = new Computer {ComputerID = 267, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c57 = new Computer {ComputerID = 268, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c58 = new Computer {ComputerID = 269, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c59 = new Computer {ComputerID = 280, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c60 = new Computer {ComputerID = 281, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c61 = new Computer {ComputerID = 282, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c62 = new Computer {ComputerID = 283, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c63 = new Computer {ComputerID = 284, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c64 = new Computer {ComputerID = 285, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c65 = new Computer {ComputerID = 286, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c66 = new Computer {ComputerID = 287, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c67 = new Computer {ComputerID = 288, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c68 = new Computer {ComputerID = 289, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c69 = new Computer {ComputerID = 290, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c70 = new Computer {ComputerID = 291, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c71 = new Computer {ComputerID = 292, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c72 = new Computer {ComputerID = 293, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c73 = new Computer {ComputerID = 294, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };
                Computer c74 = new Computer {ComputerID = 295, SoftwareInstalled = "Adobe Photoshop, Microsoft Office, Unity Hub, Visual Studio" };


                //Labs: 36 to 38 is in the start of the Computer_LabID 
                Computer_Lab cl1 = new Computer_Lab()   {Computer_LabID = 361, Location = "B2307", IsAvailable = false };
                Computer_Lab cl2 = new Computer_Lab()   {Computer_LabID = 362, Location = "B2308", IsAvailable = true };
                Computer_Lab cl3 = new Computer_Lab()   {Computer_LabID = 363, Location = "B2309", IsAvailable = false };
                Computer_Lab cl4 = new Computer_Lab()   {Computer_LabID = 364, Location = "A2329", IsAvailable = true };
                Computer_Lab cl5 = new Computer_Lab()   {Computer_LabID = 365, Location = "A2324", IsAvailable = false };
                Computer_Lab cl6 = new Computer_Lab()   {Computer_LabID = 366, Location = "A2326", IsAvailable = true };
                Computer_Lab cl7 = new Computer_Lab()   {Computer_LabID = 367, Location = "C2246", IsAvailable = false };
                Computer_Lab cl8 = new Computer_Lab()   {Computer_LabID = 368, Location = "C2244", IsAvailable = true };
                Computer_Lab cl9 = new Computer_Lab()   {Computer_LabID = 369, Location = "C2248", IsAvailable = false };
                Computer_Lab cl10 = new Computer_Lab()  {Computer_LabID = 361, Location = "B2448", IsAvailable = false };
                Computer_Lab cl11 = new Computer_Lab()  {Computer_LabID = 362, Location = "B2444", IsAvailable = true };
                Computer_Lab cl12 = new Computer_Lab()  {Computer_LabID = 363, Location = "B2445", IsAvailable = false };
                Computer_Lab cl13 = new Computer_Lab()  {Computer_LabID = 364, Location = "A2642", IsAvailable = true };
                Computer_Lab cl14 = new Computer_Lab()  {Computer_LabID = 365, Location = "A2643", IsAvailable = false };
                Computer_Lab cl15 = new Computer_Lab()  {Computer_LabID = 366, Location = "A2645", IsAvailable = true };
                Computer_Lab cl16 = new Computer_Lab()  {Computer_LabID = 367, Location = "C2642", IsAvailable = false };
                Computer_Lab cl17 = new Computer_Lab()  {Computer_LabID = 368, Location = "C2643", IsAvailable = true };
                Computer_Lab cl18 = new Computer_Lab()  {Computer_LabID = 368, Location = "C2644", IsAvailable = true };
                Computer_Lab cl19 = new Computer_Lab()  {Computer_LabID = 369, Location = "B2954", IsAvailable = false };
                Computer_Lab cl20 = new Computer_Lab()  {Computer_LabID = 370, Location = "B2955", IsAvailable = true };
                Computer_Lab cl21 = new Computer_Lab()  {Computer_LabID = 371, Location = "B2956", IsAvailable = false };
                Computer_Lab cl22 = new Computer_Lab()  {Computer_LabID = 372, Location = "A2193", IsAvailable = true };
                Computer_Lab cl23 = new Computer_Lab()  {Computer_LabID = 373, Location = "A2194", IsAvailable = false };
                Computer_Lab cl24 = new Computer_Lab()  {Computer_LabID = 374, Location = "A2195", IsAvailable = true };
                Computer_Lab cl25 = new Computer_Lab()  {Computer_LabID = 375, Location = "C2154", IsAvailable = false };
                Computer_Lab cl26 = new Computer_Lab()  {Computer_LabID = 376, Location = "C2156", IsAvailable = true };
                Computer_Lab cl27 = new Computer_Lab()  {Computer_LabID = 377, Location = "C2157", IsAvailable = false };
                Computer_Lab cl28 = new Computer_Lab()  {Computer_LabID = 378, Location = "B2236", IsAvailable = false };
                Computer_Lab cl39 = new Computer_Lab()  {Computer_LabID = 379, Location = "B2238", IsAvailable = true };
                Computer_Lab cl30 = new Computer_Lab()  {Computer_LabID = 380, Location = "B2239", IsAvailable = false };
                Computer_Lab cl31 = new Computer_Lab()  {Computer_LabID = 381, Location = "A6578", IsAvailable = true };
                Computer_Lab cl32 = new Computer_Lab()  {Computer_LabID = 382, Location = "A6579", IsAvailable = false };
                Computer_Lab cl33 = new Computer_Lab()  {Computer_LabID = 383, Location = "A6574", IsAvailable = true };
                Computer_Lab cl34 = new Computer_Lab()  {Computer_LabID = 384, Location = "C3465", IsAvailable = false };
                Computer_Lab cl35 = new Computer_Lab()  {Computer_LabID = 385, Location = "C3466", IsAvailable = true };
                Computer_Lab cl36 = new Computer_Lab()  {Computer_LabID = 385, Location = "C3467", IsAvailable = true };



                //Exam: 94 is in the start of the Computer_LabID 
                Exam_Lab el1 = new Exam_Lab { Exam_LabID = 941, CourseName = "Games Development L7 - Y2", TypeOfExam = "3D Game Programming",           DateOfExam = new DateTime(2024, 12, 15), TeacherName = "Neil Gannon"};
                Exam_Lab el2 = new Exam_Lab { Exam_LabID = 942, CourseName = "Games Development L7 - Y3", TypeOfExam = "Math 3",                        DateOfExam = new DateTime(2024, 12, 15), TeacherName = "Kieran Hughes" };
                Exam_Lab el3 = new Exam_Lab { Exam_LabID = 943, CourseName = "Games Development L7 - Y1", TypeOfExam = "Object Oriented Development",   DateOfExam = new DateTime(2024, 12, 15), TeacherName = "Keith McManus" };
                Exam_Lab el4 = new Exam_Lab { Exam_LabID = 944, CourseName = "Games Development L6 - Y2", TypeOfExam = "Software Quality and Testing",  DateOfExam = new DateTime(2024, 12, 15), TeacherName = "Vivion Kinsella" };
                Exam_Lab el5 = new Exam_Lab { Exam_LabID = 945, CourseName = "Games Development L6 - Y1", TypeOfExam = "Math 1",                        DateOfExam = new DateTime(2024, 12, 15), TeacherName = "Kieran Hughes" };
                Exam_Lab el6 = new Exam_Lab { Exam_LabID = 946, CourseName = "Games Development L8 - Y1", TypeOfExam = "Software Quality and Testing ", DateOfExam = new DateTime(2024, 12, 15), TeacherName = "Vivion Kinsella" };
                Exam_Lab el7 = new Exam_Lab { Exam_LabID = 947, CourseName = "Games Development L8 - Y2", TypeOfExam = "Object Oriented Development",   DateOfExam = new DateTime(2024, 12, 15), TeacherName = "Keith McManus" };
                Exam_Lab el8 = new Exam_Lab { Exam_LabID = 948, CourseName = "Games Development L8 - Y3", TypeOfExam = "Software Quality and Testing",  DateOfExam = new DateTime(2024, 12, 15), TeacherName = "Vivion Kinsella" };
                Exam_Lab el9 = new Exam_Lab { Exam_LabID = 949, CourseName = "Games Development L8 - Y4", TypeOfExam = "3D Game Programming",           DateOfExam = new DateTime(2024, 12, 15), TeacherName = "Neil Gannon" };

                //Add the Computers into the Labs
                cl1.Computers.Add(c1);
                cl1.Computers.Add(c2);   
                cl1.Computers.Add(c3);
                cl2.Computers.Add(c4);
                cl2.Computers.Add(c5);
                cl2.Computers.Add(c6);
                cl3.Computers.Add(c7);
                cl3.Computers.Add(c8);
                cl3.Computers.Add(c9);
                cl4.Computers.Add(c10);
                cl4.Computers.Add(c11);
                cl4.Computers.Add(c12);
                cl5.Computers.Add(c13);
                cl5.Computers.Add(c14);
                cl5.Computers.Add(c15);
                cl6.Computers.Add(c16);
                cl6.Computers.Add(c17);
                cl6.Computers.Add(c18);
                cl7.Computers.Add(c19);
                cl7.Computers.Add(c20);
                cl7.Computers.Add(c21);
                cl8.Computers.Add(c22);
                cl8.Computers.Add(c23);
                cl8.Computers.Add(c24);
                cl9.Computers.Add(c25);
                cl9.Computers.Add(c26);
                cl9.Computers.Add(c27);
                cl10.Computers.Add(c28);
                cl10.Computers.Add(c29);
                cl10.Computers.Add(c30);
                cl11.Computers.Add(c31);
                cl11.Computers.Add(c32);
                cl11.Computers.Add(c33);
                cl12.Computers.Add(c34);
                cl12.Computers.Add(c35);
                cl12.Computers.Add(c36);
                cl13.Computers.Add(c37);
                cl13.Computers.Add(c38);
                cl13.Computers.Add(c39);
                cl14.Computers.Add(c40);
                cl14.Computers.Add(c41);
                cl14.Computers.Add(c42);
                cl15.Computers.Add(c43);
                cl15.Computers.Add(c44);
                cl15.Computers.Add(c45);
                cl16.Computers.Add(c46);
                cl16.Computers.Add(c47);
                cl16.Computers.Add(c48);
                cl17.Computers.Add(c49);
                cl17.Computers.Add(c50);
                cl17.Computers.Add(c51);
                cl18.Computers.Add(c52);
                cl18.Computers.Add(c53);
                cl18.Computers.Add(c54);
                cl19.Computers.Add(c56);
                cl19.Computers.Add(c57);
                cl19.Computers.Add(c58);
                cl20.Computers.Add(c59);
                cl20.Computers.Add(c60);
                cl20.Computers.Add(c61);
                cl21.Computers.Add(c62);
                cl21.Computers.Add(c63);
                cl21.Computers.Add(c64);
                cl22.Computers.Add(c65);
                cl22.Computers.Add(c66);
                cl22.Computers.Add(c67);
                cl23.Computers.Add(c68);
                cl23.Computers.Add(c69);
                cl23.Computers.Add(c70);
                cl24.Computers.Add(c71);
                cl24.Computers.Add(c72);
                cl24.Computers.Add(c73);


                //Add the Labs into the Exam_labs
                el1.ComputerLabs.Add(cl1);
                el1.ComputerLabs.Add(cl2);
                el1.ComputerLabs.Add(cl3);
                el2.ComputerLabs.Add(cl4);
                el2.ComputerLabs.Add(cl5);
                el2.ComputerLabs.Add(cl6);
                el3.ComputerLabs.Add(cl7);
                el3.ComputerLabs.Add(cl8);
                el3.ComputerLabs.Add(cl9);
                el4.ComputerLabs.Add(cl10);
                el4.ComputerLabs.Add(cl11);
                el4.ComputerLabs.Add(cl12);
                el5.ComputerLabs.Add(cl13);
                el5.ComputerLabs.Add(cl14);
                el5.ComputerLabs.Add(cl15);
                el6.ComputerLabs.Add(cl16);
                el6.ComputerLabs.Add(cl17);
                el6.ComputerLabs.Add(cl18);
                el7.ComputerLabs.Add(cl19);
                el7.ComputerLabs.Add(cl20);
                el7.ComputerLabs.Add(cl21);
                el8.ComputerLabs.Add(cl22);
                el8.ComputerLabs.Add(cl23);
                el8.ComputerLabs.Add(cl24);

                //Add the Labs
                db.Computer_Labs.Add(cl1);
                db.Computer_Labs.Add(cl2);
                db.Computer_Labs.Add(cl3);
                db.Computer_Labs.Add(cl4);
                db.Computer_Labs.Add(cl5);
                db.Computer_Labs.Add(cl6);
                db.Computer_Labs.Add(cl7);
                db.Computer_Labs.Add(cl8);
                db.Computer_Labs.Add(cl9);

                //Add the Exam_Labs
                db.Exam_Labs.Add(el1);
                db.Exam_Labs.Add(el2);
                db.Exam_Labs.Add(el3);
                db.Exam_Labs.Add(el4);
                db.Exam_Labs.Add(el5);
                db.Exam_Labs.Add(el6);
                db.Exam_Labs.Add(el7);
                db.Exam_Labs.Add(el8);
                db.Exam_Labs.Add(el9);

                db.SaveChanges();
            }

        }
    }
}
