using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameLab_Hub
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Lists for Search Software Tab
        List<Computer_Lab> allComputer_lab = new List<Computer_Lab>();
        List<Computer_Lab> filteredComputer_lab = new List<Computer_Lab>();

        //Lists for Exam Labs Tab
        List<Exam_Lab> allExam_lab = new List<Exam_Lab>();

        public MainWindow()
        {
            InitializeComponent();
        }

        //Code for Search Software Tab
        private void tblmSearchSoftware_Loaded(object sender, RoutedEventArgs e)
        {
            //Computer_Lab lab1 = new Computer_Lab("Lab 1", "Bulding3", 20, "Adobe Photoshop, Microsoft Office", true);
            //Computer_Lab lab2 = new Computer_Lab("Lab 2", "Bulding3", 20, "Adobe Photoshop, Microsoft Office", true);
            //Computer_Lab lab3 = new Computer_Lab("Lab 3", "Bulding3", 20, "Adobe Photoshop, Microsoft Office", true);
            //Computer_Lab lab4 = new Computer_Lab("Lab 4", "Bulding3", 20, "Adobe Photoshop, Microsoft Office", true);

            //allComputer_lab.Add(lab1);
            //allComputer_lab.Add(lab2);
            //allComputer_lab.Add(lab3);
            //allComputer_lab.Add(lab4);


            //lbxListOfComputer.ItemsSource = allComputer_lab;
        }

        private void lbxListOfComputer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Computer_Lab selectedLab = lbxListOfComputer.SelectedItem as Computer_Lab;

            //if (selectedLab != null)
            //{

            //    tblRoominfo.Text = $"Room Name: {selectedLab.LabNumber}\n" +
            //        $"Number of Computers: {selectedLab.NumberOfComputers}\n" +
            //        $"Software Installed: {selectedLab.SotferwareInstalled}\n" +
            //        $"Is Available: {(selectedLab.IsAvailable ? "Yes" : "No")}"; 

            //}
        }

        private void tbxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            //string searchText = tbxSearch.Text;

            //if (string.IsNullOrEmpty(searchText))
            //{
            //    lbxListOfComputer.ItemsSource = null;
            //    lbxListOfComputer.ItemsSource = allComputer_lab;
            //}
            //else
            //{
            //    filteredComputer_lab.Clear();

            //    foreach (Computer_Lab lab in allComputer_lab)
            //    {
            //        if (lab.LabNumber.ToLower().Contains(searchText.ToLower()))
            //        {
            //            filteredComputer_lab.Add(lab);
            //        }

            //        lbxListOfComputer.ItemsSource = null;
            //        lbxListOfComputer.ItemsSource = filteredComputer_lab;
            //    }
            //}
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

            //Exam_Lab lab1 = new Exam_Lab("Lab 1", "Bulding3", 20, "Adobe Photoshop, Microsoft Office", true, "Fuck");
            //Exam_Lab lab2 = new Exam_Lab("Lab 1", "Bulding3", 20, "Adobe Photoshop, Microsoft Office", true, "Fuck");
            //Exam_Lab lab3 = new Exam_Lab("Lab 1", "Bulding3", 20, "Adobe Photoshop, Microsoft Office", true, "Fuck");
            //Exam_Lab lab4 = new Exam_Lab("Lab 1", "Bulding3", 20, "Adobe Photoshop, Microsoft Office", true, "Fuck");

            // allExam_lab.Add(lab1);
            // allExam_lab.Add(lab2);
            // allExam_lab.Add(lab3);
            // allExam_lab.Add(lab4);


            // lbxComputerExam.ItemsSource = allExam_lab;
        }

        private void lbxComputerExam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Exam_Lab selectedExam = lbxComputerExam.SelectedItem asExam_Lab;

            // if (selectedExam != null)
            // {

            //     tblExaminfo.Text = $"Room Name: {selectedExam.LabNumber}\n" +
            //         $"Number of Computers: {selectedExam.NumberOfComputers}\n" +
            //         $"Software Installed: {selectedExam.SotferwareInstalled}\n" +
            //         $"Is Available: {(selectedExam.IsAvailable ? "Yes" : "No")}\n" +
            //         $"{selectedExam.TypeOfExam}";

            // }
        }
    }
}
