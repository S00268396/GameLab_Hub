using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class TimeSlot
    {
        public int TimeSlotID { get; set; }
        public DayOfWeek Day { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public virtual List<Details> Details { get; set; }  
        public TimeSlot()
        {
            Details = new List<Details>();  
        }
    }
    public class Details
    {
        public int DetailsID { get; set; }
        public int Exam_LabID { get; set; }
        public virtual Exam_Lab ExamLab { get; set; }
        public int TimeSlotID { get; set; }
        public virtual TimeSlot TimeSlot { get; set; }
      
    }
}
