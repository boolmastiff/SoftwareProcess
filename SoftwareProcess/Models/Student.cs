﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareProcess.Models
{
    public class Student 
    {
        [DisplayName("User ID : ")]
        [Required(ErrorMessage ="This field is required")]
        public int ID { get; set; }
        public string First_name { get; set; }
        public string Surname { get; set; }
        public string Institution { get; set; }
        public string Department { get; set; }
        public string Email_address { get; set; }
        public int LDFTC { get; set; }
        [DisplayName("Password : ")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage ="This field is required")]
        public string Password { get; set; }

    }
}
