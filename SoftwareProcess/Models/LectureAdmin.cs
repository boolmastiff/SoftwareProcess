﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SoftwareProcess.Models
{
    public class LectureAdmin
    {
        public int ID { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }

    }
}
