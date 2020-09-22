using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareProcess.Models
{
    public class Course
    {
        public int ID { get; set; }
        public int Year { get; set; }
        public string Programme_Code { get; set; }
        public string Programme_Version_Description { get; set; }
        public string Intake_Code { get; set; }
        public string Ministry_Code { get; set; }
        public int ProgPoints { get; set; }
        public string Owner_Faculty { get; set; }
        public string ProgLevel { get; set; }
        public int Programme_EFTS { get; set; }
        public string Module_Code { get; set; }
        public string Module_Description { get; set; }
        public string Level { get; set; }
        public int Module_Credits { get; set; }
        public float Module_EFTS { get; set; }
        public string TSC_Category { get; set; }
        public int Funding_Classification { get; set; }

    }
}
