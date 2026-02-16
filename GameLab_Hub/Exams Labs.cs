using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLab_Hub
{
    public class Exams_Labs : Computer_Labs
    {
        public string TypeOfExam { get; set; } 
        public Exams_Labs(string labNumber, string location, int numberOfComputers, string sotferwareInstalled, bool isAvailable, string typeofexam) 
            : base(labNumber, location, numberOfComputers, sotferwareInstalled, isAvailable)
        {
            TypeOfExam = typeofexam;
        }

    }
}
