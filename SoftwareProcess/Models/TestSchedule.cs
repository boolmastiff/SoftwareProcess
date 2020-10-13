using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareProcess.Models
{
    public class TestSchedule
    {
        public int ID { get; set; }
        public int ClassID { get; set; }
        public DateTime StartTime { get; set; }
        public float Duration { get; set; }
    }
}
