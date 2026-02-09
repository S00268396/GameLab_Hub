using System.Text;
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
        List<Computer_Labs> allComputer_lab = new List<Computer_Labs> ();
        List<Computer_Labs> filteredComputer_lab = new List<Computer_Labs>();

        public MainWindow()
        {
            InitializeComponent();
        }


        //For the Search Software
        private void tblmSearchSoftware_Loaded(object sender, RoutedEventArgs e)
        {
            Computer_Labs lab1 = new Computer_Labs("Lab 1", "Bulding3", 20, "Adobe Photoshop, Microsoft Office", true);
            Computer_Labs lab2 = new Computer_Labs("Lab 2", "Bulding3", 20, "Adobe Photoshop, Microsoft Office", true);
            Computer_Labs lab3 = new Computer_Labs("Lab 3", "Bulding3", 20, "Adobe Photoshop, Microsoft Office", true);
            Computer_Labs lab4 = new Computer_Labs("Lab 4", "Bulding3", 20, "Adobe Photoshop, Microsoft Office", true);

            allComputer_lab.Add(lab1);
            allComputer_lab.Add(lab2);
            allComputer_lab.Add(lab3);
            allComputer_lab.Add(lab4);


            lbxListOfComputer.ItemsSource = allComputer_lab;
        }

        private void lbxListOfComputer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Computer_Labs selectedLab = lbxListOfComputer.SelectedItem as Computer_Labs;

            if (selectedLab != null)
            {

                tblRoominfo.Text = $"Room Name: {selectedLab.LabNumber}\n" +
                    $"Number of Computers: {selectedLab.NumberOfComputers}\n" +
                    $"Software Installed: {selectedLab.SotferwareInstalled}\n" +
                    $"Is Available: {(selectedLab.IsAvailable ? "Yes" : "No")}";

            }
        }

        private void tbxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string searchText = tbxSearch.Text;

            if (string.IsNullOrEmpty(searchText))
            {
                lbxListOfComputer.ItemsSource = null;
                lbxListOfComputer.ItemsSource = allComputer_lab;
            }
            else
            {
                filteredComputer_lab.Clear();

                foreach (Computer_Labs lab in allComputer_lab)
                {
                    if (lab.LabNumber.ToLower().Contains(searchText.ToLower()))
                    {
                        filteredComputer_lab.Add(lab);
                    }

                    lbxListOfComputer.ItemsSource = null;
                    lbxListOfComputer.ItemsSource = filteredComputer_lab;
                }
            }
        }

        private void btnExamLabs_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnSearchSoftware1_Click(object sender, RoutedEventArgs e)
        {
            //set active tab to search software
                tabCTRL.SelectedIndex = 0;
        }

        //Exams Labs
    }
}