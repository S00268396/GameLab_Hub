using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Linq;
using System.Windows.Media;
using System.Diagnostics.PerformanceData;
using System.Text;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //The Database
        ComputerData CD = new ComputerData();

        public MainWindow()
        {
            InitializeComponent();
        }

        //|-------------------- Search Software Tab --------------------|
        private void tblmSearchSoftware_Loaded(object sender, RoutedEventArgs e)
        {  
            //This work but it show {Computer_LabID = 1} {Loction = A235} 
            //var AllComs = CD.Computer_Labs
            //           .Select(id => new
            //           {
            //               id.Computer_LabID,
            //               id.Location
            //           })
            //           .ToList();

            //lbxListOfComputer.ItemsSource = AllComs;

            //Had to use <ListBox.ItemTemplate> and <DataTemplate> to Binding Computer_LabID and Loction to the ListBox, which meaning that only  Computer_LabID and Loction
            //I learn how to use this menth from a website - https://stackoverflow.com/questions/2456643/wpf-very-basic-listbox-itemtemplate-question
           
            //Bind the list of computer Labs when the tabs loads with the Computers
            lbxListOfComputer.ItemsSource = CD.Computer_Labs.Include("Computers").ToList();

        }

        private void lbxListOfComputer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Take whatever the user clicked in the ListBox.
            //If it is a Computer Lab, it remember as RoomSelected
            Computer_Lab RoomSelected = lbxListOfComputer.SelectedItem as Computer_Lab;

            if (RoomSelected != null)
            {
                //tblRoominfo.Text = $"Computer LabID: {RoomSelected.Computer_LabID}\n" +
                //                   $"Location: {RoomSelected.Location}\n" +
                //                   $"Is Available: {(RoomSelected.IsAvailable ? "Yes" : "No")}\n";

                //This work but it don't show the computers. Maybe use the join things

                //tblCominfo.Text = $"Computer: {RoomSelected.Computers}\n" +
                //                  $"SoftwareInstalled: {RoomSelected.Computers}";

                // After look up the string Join -so it takes the datas and join in into one string(Maybe it will work)
                //It does work but it only show one computer, Maybe use a TextBox and not TextBlock - I was right
                //https://stackoverflow.com/questions/9310607/string-join-in-linq-to-entity-queries
                //tbxCominfo.Text = string.Join("\n\n", RoomSelected.Computers.Select(ec => $"ComputerID: {ec.ComputerID} \n SoftwareInstalled: {ec.SoftwareInstalled}"));

                //So It don't look good when the Computer Labs Info and Computers are not together so I find something call StringBuilder, it a mutable class - 
                //It acts like a builder that holds a buffer of characters and allows you to append, insert, or remove text without creating a new string every time.
                //https://learn.microsoft.com/en-us/dotnet/standard/base-types/stringbuilder

                //Build a detailed string for the lab and computers in it
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Computer LabID:  {RoomSelected.Computer_LabID}");
                sb.AppendLine($"Location:  {RoomSelected.Location}");
                sb.AppendLine($"Available:  {(RoomSelected.IsAvailable ? "Yes" : "No")}");
                sb.AppendLine("\n");
                sb.AppendLine("Computers in the Computer Lab:");

                //List all Computers in the selected Computer Lab
                foreach (var computer in RoomSelected.Computers)
                {
                    sb.AppendLine($"ComputerID: {computer.ComputerID} \n SoftwareInstalled: {computer.SoftwareInstalled}");
                }
                
                //Displayer the info in the TextBlock
                tblRoominfo.Text = sb.ToString();
            }
        }

        private void tbxSearch_KeyUp(object sender, KeyEventArgs e)
        {

            //Get the text currently entered in the search TextBox
            string searchText = tbxSearch.Text;

            //Filter the list of computer Labs based on the search text
            //Check if the search text is present in Computer_LabID
            //Or If the Location string contains the search text
            //The filtered results are transformed into list
            var FilteredComputer_Lab = CD.Computer_Labs
                         .Where(s => s.Computer_LabID.ToString().Contains(searchText) ||  s.Location.ToString().Contains(searchText))
                         .ToList();

            //Reset the ListBox item source so it updates right
            lbxListOfComputer.ItemsSource = null;

            //Set the ListBox new item source to the filtered list
            lbxListOfComputer.ItemsSource = FilteredComputer_Lab;
        }

        //|-------------------- Timetable Tab --------------------|
        //This create the timeable maybe use the DataGrid with the DataGridTextColumn and Binding to show the data in the DataGrid
        private void dgTimetable_Loaded(object sender, RoutedEventArgs e)
        {
            //Maybe I need to add a relationship in this part - so the relationship is that TimeSlot have many Details and each Details have one Exam_Lab.
            //Because the relationship is one to many, it duplicating three times in the Exam_Lab so I need to use Select
            
            //Load the Timetable into the DataGrid with exam and lab details
            dgTimetable.ItemsSource = CD.Exam_Labs.Include("ComputerLabs")
                                                   .Select(el => el.ComputerLabs.Select(c => new //Create a new object for the DataGrid by smoothing the data
                                                   {
                                                       DateOfExam = el.DateOfExam,
                                                       CourseName = el.CourseName,
                                                       TypeOfExam = el.TypeOfExam,
                                                       YearGroup = el.YearGroup,
                                                       Semester = el.Semester,
                                                       TeacherName = el.TeacherName,
                                                       DateOfexam = el.DateOfExam,
                                                       LongOfTime = el.LongOfTime,

                                                       //Put togther lab data into single string
                                                       Labs = "Computer LabID: "+ c.Computer_LabID +" - Location: " + c.Location 
                                                   }))
                                                  .ToList();
        }

        //|--------------------  Exam Labs Tab --------------------|
        private void tblmExams_Labs_Loaded(object sender, RoutedEventArgs e)
        {
            //Load exam labs into ListBox
            lbxComputerExam.ItemsSource = CD.Exam_Labs.Include("ComputerLabs").ToList();
        }

        private void lbxComputerExam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //Take whatever the user clicked in the ListBox.
            //If it is a Exam Lab, it remember as ExamSelected
            Exam_Lab ExamSelected = lbxComputerExam.SelectedItem as Exam_Lab;

            if (ExamSelected != null)
            {
                //tblExaminfo.Text = $"Exam LabID: {ExamSelected.Exam_LabID}\n" +
                //                   $"Course Name: {ExamSelected.CourseName}\n" +
                //                   $"Year Group: {ExamSelected.YearGroup}\n" +
                //                   $"Type Of Exam: {ExamSelected.TypeOfExam}\n" +
                //                   $"Date Of Exam: {ExamSelected.DateOfExam}\n" +
                //                   $"Time: {ExamSelected.LongOfTime}\n"+
                //                   $"Long Of Time: {ExamSelected.LongOfTime}\n" +
                //                   $"Teacher Name: {ExamSelected.TeacherName}\n";                               

                //Build a detailed string for the exam and assigned computer Lab
                StringBuilder sB = new StringBuilder();
                sB.AppendLine($"Exam LabID:  {ExamSelected.Exam_LabID}");
                sB.AppendLine($"Course Name:  {ExamSelected.CourseName}");
                sB.AppendLine($"Year Group:  {ExamSelected.YearGroup}");
                sB.AppendLine($"Semester: {ExamSelected.Semester}");
                sB.AppendLine($"Type Of Exam:  {ExamSelected.TypeOfExam}");
                sB.AppendLine($"Date Of Exam:  {ExamSelected.DateOfExam}");
                sB.AppendLine($"Time:  {ExamSelected.LongOfTime}");
                sB.AppendLine($"long Of Time:  {ExamSelected.LongOfTime}");
                sB.AppendLine($"Teacher Name:  {ExamSelected.TeacherName}");
                sB.AppendLine();
                sB.AppendLine("Assigned Computer Labs:");

                //List all Computer Lab in this Exam
                if (ExamSelected.ComputerLabs != null)
                {
                    foreach (var exam in ExamSelected.ComputerLabs)
                    {
                        sB.AppendLine($"Computer LabID: {exam.Computer_LabID}\n Location: {exam.Location}");
                    }

                }

                //Displayer the info in the TextBlock
                tblExaminfo.Text = sB.ToString();
            }
        }

        private void cmbxSearchCourse_Loaded(object sender, RoutedEventArgs e)
        {
            //This work but it show more then one of the Courses
            //- I think need to change the code in this and in SelectionChanged

            //Load all exam lab records from the database
            var Course = CD.Exam_Labs.ToList();

            //After removing duplicates by grouping the records by CourseName,
            //Choose the first entry from each group to represent that course
            var OneCourse = Course
                         .GroupBy(c => c.CourseName)
                         .Select(l => l.FirstOrDefault())
                         .ToList();

            //Insert an All Courses option at the top of the ComboBox
            OneCourse.Insert(0, new Exam_Lab { CourseName = "All Courses" });  

            //Bind the list of courses to the ComboBox
            cmbxSearchCourse.ItemsSource = OneCourse;

            //Display only the CourseName property in the ComBox
            cmbxSearchCourse.DisplayMemberPath = "CourseName";

        }

        private void cmbxSearchCourse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Check if the selected item in the ComBox is an Exam Labs
            if (cmbxSearchCourse.SelectedItem is Exam_Lab selectedCourse)
            {
                //If the user selected the All Courses option
                if (selectedCourse.CourseName == "All Courses")
                {
                    //Display all Exam Labs in the ListBox
                    lbxComputerExam.ItemsSource = CD.Exam_Labs.ToList();
                }
                else
                {
                    //Otherwise, filter Exam Lbs by the selected course name
                    lbxComputerExam.ItemsSource = CD.Exam_Labs
                                                  .Where(c => c.CourseName == selectedCourse.CourseName)
                                                  .ToList();
                }
            }
        }

        private void cmbxSearchTeacher_Loaded(object sender, RoutedEventArgs e)
        {
            //Load all exam lab records from the database
            var Teachers = CD.Exam_Labs.ToList();

            //After removing duplicates by grouping the records by CourseName,
            //Choose the first entry from each group to represent that course
            var OneTeachers = Teachers
                              .GroupBy(t => t.TeacherName)
                              .Select(fe => fe.FirstOrDefault())
                              .ToList();

            //Insert an All Teacher option at the top of the ComboBox
            OneTeachers.Insert(0, new Exam_Lab { TeacherName = "All Teacher"});

            //Bind the list of Teacher to the ComboBox
            cmbxSearchTeacher.ItemsSource = OneTeachers;

            //Display only the TeacherName property in the ComBox
            cmbxSearchTeacher.DisplayMemberPath = "TeacherName";


        }

        private void cmbxSearchTeacher_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Check if the selected item in the ComBox is an Exam Labs
            if (cmbxSearchTeacher.SelectedItem is Exam_Lab selectedTeacher)
            {
                //If the user selected the All Teacher option
                if (selectedTeacher.TeacherName == "All Teacher")
                {
                    //Display all Exam Labs in the ListBox
                    lbxComputerExam.ItemsSource = CD.Exam_Labs.ToList();
                }
                else
                {
                    //Otherwise, filter Exam Lbs by the selected Teacher name

                    lbxComputerExam.ItemsSource = CD.Exam_Labs
                                                  .Where(t => t.TeacherName == selectedTeacher.TeacherName)
                                                  .ToList();

                }
            }
        }

        private void cmbxSearchYear_Loaded(object sender, RoutedEventArgs e)
        {
            //Load all exam lab records from the database
            var Years = CD.Exam_Labs.ToList();

            //After removing duplicates by grouping the records by CourseName,
            //Choose the first entry from each group to represent that course
            var OneYear = Years
                          .GroupBy(y => y.YearGroup)
                          .Select(fe => fe.FirstOrDefault())
                          .ToList();

            //Insert an All Year option at the top of the ComboBox
            OneYear.Insert(0, new Exam_Lab { YearGroup = "All Years"});

            //Bind the list of Year to the ComboBox
            cmbxSearchYear.ItemsSource = OneYear;

            //Display only the YearGroup property in the ComBox
            cmbxSearchYear.DisplayMemberPath = "YearGroup";

           
        }

        private void cmbxSearchYear_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Check if the selected item in the ComBox is an Exam Labs
            if (cmbxSearchYear.SelectedItem is Exam_Lab selectedYear)
            {
                //If the user selected the All Year option
                if (selectedYear.YearGroup == "All Years")
                {
                    //Display all Exam Labs in the ListBox
                    lbxComputerExam.ItemsSource = CD.Exam_Labs.ToList();
                }
                else
                {
                    //Otherwise, filter Exam Lbs by the selected YearGroup
                    lbxComputerExam.ItemsSource = CD.Exam_Labs
                                                  .Where(y => y.YearGroup == selectedYear.YearGroup)
                                                  .ToList();                  
                }

            }           
        }

        private void cmbxSearchExam_Loaded(object sender, RoutedEventArgs e)
        {
            //Load all exam lab records from the database
            var Exams = CD.Exam_Labs.ToList();

            //After removing duplicates by grouping the records by CourseName,
            //Choose the first entry from each group to represent that course
            var OneExam = Exams
                          .GroupBy(el => el.TypeOfExam)
                          .Select(fe => fe.FirstOrDefault())
                          .ToList();

            //Insert an All Types option at the top of the ComboBox
            OneExam.Insert(0, new Exam_Lab { TypeOfExam = "All Types" });

            //Bind the list of Exam to the ComboBox
            cmbxSearchExam.ItemsSource = OneExam;

            //Display only the TypeOfExam property in the ComBox
            cmbxSearchExam.DisplayMemberPath = "TypeOfExam";           
        }

        private void cmbxSearchExam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Check if the selected item in the ComBox is an Exam Labs
            if (cmbxSearchExam.SelectedItem is Exam_Lab selectedExam)
            {
                //If the user selected the All Types option
                if (selectedExam.TypeOfExam == "All Types")
                {
                    //Display all Exam Labs in the ListBox
                    lbxComputerExam.ItemsSource = CD.Exam_Labs.ToList();
                }
                else                
                {
                    //Otherwise, filter Exam Lbs by the selected Type Of Exam
                    lbxComputerExam.ItemsSource = CD.Exam_Labs
                                                  .Where(t => t.TypeOfExam == selectedExam.TypeOfExam)
                                                  .ToList();

                }

            }
        }

        //|-------------------- Buttons --------------------|

        //Buttons in Search Software
        private void btnExamLabs_Click(object sender, RoutedEventArgs e)
        {
            tabCTRL.SelectedIndex = 2;
        }
        private void btnTimetable_Click(object sender, RoutedEventArgs e)
        {
            tabCTRL.SelectedIndex = 1;
        }
        //Buttons in Timetable
        private void btnExamsLabs_Click(object sender, RoutedEventArgs e)
        {
            tabCTRL.SelectedIndex = 2;
        }
        private void btnSearchSoftware1_Click(object sender, RoutedEventArgs e)
        {
            //set active tab to search software
            tabCTRL.SelectedIndex = 0;
        }

        //Buttons in Exam Labs
        private void btnSearchSoftware_Click(object sender, RoutedEventArgs e)
        {
            tabCTRL.SelectedIndex = 0;
        }
        private void btnTimetable1_Click(object sender, RoutedEventArgs e)
        {
            tabCTRL.SelectedIndex = 1;
        }
    } 

}
