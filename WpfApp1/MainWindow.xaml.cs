using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Linq;
using System.Windows.Media;

namespace GameLab_Hub
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

        //The Com
        ComputerData CD = new ComputerData();

        //Lists for Exam Labs Tab
        List<Exam_Lab> allExam_lab = new List<Exam_Lab>();

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

            lbxListOfComputer.ItemsSource = CD.Computer_Labs.Include("Computers").ToList();

        }

        private void lbxListOfComputer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Computer_Lab RoomSelected = lbxListOfComputer.SelectedItem as Computer_Lab;
           
            if (RoomSelected != null )
            {
                tblRoominfo.Text = $"Computer LabID: {RoomSelected.Computer_LabID}\n" +
                                   $"Location: {RoomSelected.Location}\n" +
                                   $"Is Available: {(RoomSelected.IsAvailable ? "Yes" : "No")}\n";

                //This work but it don't show the computers. Maybe use the join things
                
                //tblCominfo.Text = $"Computer: {RoomSelected.Computers}\n" +
                //                  $"SoftwareInstalled: {RoomSelected.Computers}";

                // After look up the string Join -so it takes the datas and join in into one string(Maybe it will work)
                //It does work but it only show one computer, Maybe use a tblm and not tbl - I was right

                tbxCominfo.Text = string.Join("\n\n",RoomSelected.Computers.Select(ec => $"ComputerID: {ec.ComputerID} \n SoftwareInstalled: {ec.SoftwareInstalled}"));
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

            lbxComputerExam.ItemsSource = CD.Exam_Labs.ToList();            
        }

        private void lbxComputerExam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Exam_Lab ExamSelected = lbxComputerExam.SelectedItem as Exam_Lab;

            if (ExamSelected != null)
            {
                tblExaminfo.Text = $"Exam LabID: {ExamSelected.Exam_LabID}\n" +
                                   $"Course Name: {ExamSelected.CourseName}\n" +
                                   $"Type Of Exam: {ExamSelected.TypeOfExam}\n" +
                                   $"Date Of Exam: {ExamSelected.DateOfExam}\n" +
                                   $"Teacher Name: {ExamSelected.TeacherName}\n";

                //tblLabinfo.Text = $""
            }

           
        }

        
    }
}
