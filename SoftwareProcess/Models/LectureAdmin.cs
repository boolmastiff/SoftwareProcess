using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.CompilerServices;

namespace SoftwareProcess.Models
{
    public class LectureAdmin
    {
        public int ID { get; set; }
        public string Password { get; set; }
        public string First_Name { get; set; }
        public string Surname { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public string Phone { get; set; }

    }
}
