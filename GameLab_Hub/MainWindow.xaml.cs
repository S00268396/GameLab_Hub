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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tblmSearchSoftware_Loaded(object sender, RoutedEventArgs e)
        {
            Computer_Labs lab1 = new Computer_Labs("Lab 1", 20, "Adobe Photoshop, Microsoft Office", true); 

            allComputer_lab.Add(lab1);

            allComputer_lab.Sort();

            lbxListOfComputer.ItemsSource = allComputer_lab;
        }

        private void lbxListOfComputer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Computer_Labs selectedLab = lbxListOfComputer.SelectedItem as Computer_Labs;

            if (selectedLab != null)
            {
                lbxSoftwareListbox.ItemsSource = string.Format($"The Room number of the Computer Lab: {selectedLab.LabNumber}, Number of Computers: {selectedLab.NumberOfComputers} Is Available: {selectedLab.IsAvailable}");




            }
        }
    }
}