using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLab_Hub
{
    public class Computer_Labs
    {
        public string LabNumber { get; set; }
        public int NumberOfComputers { get; set; }
        public string SotferwareInstalled { get; set; }
        public bool IsAvailable { get; set; }
        public Computer_Labs(string labNumber, int numberOfComputers, string sotferwareInstalled, bool isAvailable)
        {
            LabNumber = labNumber;
            SotferwareInstalled = sotferwareInstalled;
            NumberOfComputers = numberOfComputers;
            IsAvailable = isAvailable;
        }


        public void DisplayLabInfo()
        {
            Console.WriteLine($"Lab Name: {LabNumber}");
            Console.WriteLine($"Number of Computers: {NumberOfComputers}");
            Console.WriteLine($"Is Available: {IsAvailable}");
        }
    }
}
