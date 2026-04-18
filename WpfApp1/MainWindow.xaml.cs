using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Linq;
using System.Windows.Media;
using System.Diagnostics.PerformanceData;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //The Com
        ComputerData CD = new ComputerData();

        public MainWindow()
        {
            InitializeComponent();
        }

        //Code for Search Software Tab
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
            lbxListOfComputer.ItemsSource = CD.Computer_Labs.Include("Computers").ToList();

        }

        private void lbxListOfComputer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Computer_Lab RoomSelected = lbxListOfComputer.SelectedItem as Computer_Lab;

            if (RoomSelected != null)
            {
                tblRoominfo.Text = $"Computer LabID: {RoomSelected.Computer_LabID}\n" +
                                   $"Location: {RoomSelected.Location}\n" +
                                   $"Is Available: {(RoomSelected.IsAvailable ? "Yes" : "No")}\n";

                //This work but it don't show the computers. Maybe use the join things

                //tblCominfo.Text = $"Computer: {RoomSelected.Computers}\n" +
                //                  $"SoftwareInstalled: {RoomSelected.Computers}";

                // After look up the string Join -so it takes the datas and join in into one string(Maybe it will work)
                //It does work but it only show one computer, Maybe use a TextBox and not TextBlock - I was right
                //https://stackoverflow.com/questions/9310607/string-join-in-linq-to-entity-queries
                tbxCominfo.Text = string.Join("\n\n", RoomSelected.Computers.Select(ec => $"ComputerID: {ec.ComputerID} \n SoftwareInstalled: {ec.SoftwareInstalled}"));
            }


        }

        private void tbxSearch_KeyUp(object sender, KeyEventArgs e)
        {

            //This working
            string searchText = tbxSearch.Text;

            var FilteredComputer_Lab = CD.Computer_Labs
                         .Where(s => s.Computer_LabID.ToString().Contains(searchText) ||
                                 s.Location.ToString().Contains(searchText))
                         .ToList();

            lbxListOfComputer.ItemsSource = null;
            lbxListOfComputer.ItemsSource = FilteredComputer_Lab;
        }

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

        //Code for Timetable Tab
        //This create the timeable maybe use the DataGrid with the DataGridTextColumn and Binding to show the data in the DataGrid
        private void dgTimetable_Loaded(object sender, RoutedEventArgs e)
        {
            //Maybe I need to add a relationship in this part - so the relationship is that TimeSlot have many Details and each Details have one Exam_Lab.
            //Because the relationship is one to many, it duplicating three times in the Exam_Lab so I need to use Select
            dgTimetable.ItemsSource = CD.Exam_Labs.Include("ComputerLabs")
                                                   .Select(el => el.ComputerLabs.Select(c => new
                                                   {
                                                       DateOfExam = el.DateOfExam,
                                                       CourseName = el.CourseName,
                                                       TypeOfExam = el.TypeOfExam,
                                                       YearGroup = el.YearGroup,
                                                       TeacherName = el.TeacherName,
                                                       DateOfexam = el.DateOfExam,
                                                       LongOfTime = el.LongOfTime,
                                                       Labs = "Computer LabID: "+ c.Computer_LabID + " - Location: " + c.Location 
                                                   }))
                                                  .ToList();
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
        //Code for Exam Labs Tab
        private void tblmExams_Labs_Loaded(object sender, RoutedEventArgs e)
        {

            lbxComputerExam.ItemsSource = CD.Exam_Labs.Include("ComputerLabs").ToList();
        }

        private void lbxComputerExam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Exam_Lab ExamSelected = lbxComputerExam.SelectedItem as Exam_Lab;

            if (ExamSelected != null)
            {
                tblExaminfo.Text = $"Exam LabID: {ExamSelected.Exam_LabID}\n" +
                                   $"Course Name: {ExamSelected.CourseName}\n" +
                                   $"Year Group: {ExamSelected.YearGroup}\n" +
                                   $"Type Of Exam: {ExamSelected.TypeOfExam}\n" +
                                   $"Date Of Exam: {ExamSelected.DateOfExam}\n" +
                                   $"Time: {ExamSelected.LongOfTime}\n"+
                                   $"Long Of Time: {ExamSelected.LongOfTime}\n" +
                                   $"Teacher Name: {ExamSelected.TeacherName}\n";

                txbLabinfo.Text = string.Join("\n\n", ExamSelected.ComputerLabs.Select(cl => $"Computer LabID: {cl.Computer_LabID}\n Location: {cl.Location}"));
            }


        }

        private void cmbxSearchCourse_Loaded(object sender, RoutedEventArgs e)
        {
            var Course = CD.Exam_Labs.ToList();

            Course.Insert(0, new Exam_Lab { CourseName = "All Courses" });  

            cmbxSearchCourse.ItemsSource = Course;

            cmbxSearchCourse.DisplayMemberPath = "CourseName";

            cmbxSearchCourse.SelectedValuePath = "Exam_LabID";
        }

        private void cmbxSearchCourse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbxSearchCourse.SelectedItem is Exam_Lab selectedCourse)
            {
                if (selectedCourse.CourseName == "All Courses")
                {
                    lbxComputerExam.ItemsSource = CD.Exam_Labs.ToList();
                }
                else
                {

                    lbxComputerExam.ItemsSource = new List<Exam_Lab> { selectedCourse };

                }
            }
        }

        private void cmbxSearchTeacher_Loaded(object sender, RoutedEventArgs e)
        {
            var Teachers = CD.Exam_Labs.ToList();

            Teachers.Insert(0, new Exam_Lab { TeacherName = "All Teacher"});

            cmbxSearchTeacher.ItemsSource = Teachers;

            cmbxSearchTeacher.DisplayMemberPath = "TeacherName";
        }

        private void cmbxSearchTeacher_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (cmbxSearchTeacher.SelectedItem is Exam_Lab selectedTeacher)
            {
                if (selectedTeacher.TeacherName == "All Teacher")
                {
                    lbxComputerExam.ItemsSource = CD.Exam_Labs.ToList();
                }
                else
                {

                    lbxComputerExam.ItemsSource = new List<Exam_Lab> { selectedTeacher };

                }
            }
        }

        private void cmbxSearchYear_Loaded(object sender, RoutedEventArgs e)
        {
            var Years = CD.Exam_Labs.ToList();

            Years.Insert(0, new Exam_Lab { YearGroup = "All Years"});
            cmbxSearchYear.ItemsSource = Years;
            cmbxSearchYear.DisplayMemberPath = "YearGroup";
        }

        private void cmbxSearchYear_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbxSearchYear.SelectedItem is Exam_Lab selectedYear)
            {

                if (selectedYear.YearGroup == "All Years")
                {
                    lbxComputerExam.ItemsSource = CD.Exam_Labs.ToList();
                }
                else
                {

                    lbxComputerExam.ItemsSource = new List<Exam_Lab> { selectedYear };

                }

            }
        }

        private void cmbxSearchExam_Loaded(object sender, RoutedEventArgs e)
        {
            var Exams = CD.Exam_Labs.ToList();

            Exams.Insert(0, new Exam_Lab { TypeOfExam = "All Types" });
            cmbxSearchExam.ItemsSource = Exams;
            cmbxSearchExam.DisplayMemberPath = "TypeOfExam";
        }

        private void cmbxSearchExam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbxSearchExam.SelectedItem is Exam_Lab selectedExam)
            {
                if (selectedExam.TypeOfExam == "All Types")
                {
                    lbxComputerExam.ItemsSource = CD.Exam_Labs.ToList();
                }
                else                
                {

                    lbxComputerExam.ItemsSource = new List<Exam_Lab> { selectedExam };

                }

            }
          
        }
  
    } 

}
