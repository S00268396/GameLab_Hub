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
        public string Location { get; set; }
        public int NumberOfComputers { get; set; }
        public string SotferwareInstalled { get; set; }
        public bool IsAvailable { get; set; }
        public Computer_Labs(string labNumber, string location, int numberOfComputers, string sotferwareInstalled, bool isAvailable)
        {
            LabNumber = labNumber;
            Location = location;
            SotferwareInstalled = sotferwareInstalled;
            NumberOfComputers = numberOfComputers;
            IsAvailable = isAvailable;
        }

        public override string ToString()
        {
            return LabNumber;
        }
    }
}
