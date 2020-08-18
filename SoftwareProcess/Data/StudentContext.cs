using Microsoft.EntityFrameworkCore;
using SoftwareProcess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareProcess.Controllers
{
    public class StudentContext : DbContext
    {

        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        { }
        public DbSet<Student> Students { get; set; }
    }
}
