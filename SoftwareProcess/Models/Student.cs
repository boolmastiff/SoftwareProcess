using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareProcess.Models
{
    public class Student 
    {
        
        public int UserID { get; set; }

        public string UserName { get; set; }

        public string UserPassword { get; set; }

        public DateTime DOB { get; set; }

        public string Phone { get; set; }

    }
}
