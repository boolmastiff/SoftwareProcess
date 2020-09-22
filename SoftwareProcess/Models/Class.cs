using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace SoftwareProcess.Models
{
    public class Class
    {
        public int ID { get; set; }
        public int CourseID { get; set; }
        public DateTime Start_DateTime { get; set; }
        public float Duration { get; set; }
        public string Type { get; set; }
    }
}
