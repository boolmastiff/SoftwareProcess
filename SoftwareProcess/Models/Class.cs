using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace SoftwareProcess.Models
{
    public class Class
    {
        public string Module_Code { get; set; }
        public string Intake_Code { get; set; }
        public DateTime Start_DateTime { get; set; }
        public int Duration { get; set; }
        public string Type { get; set; }
    }
}
