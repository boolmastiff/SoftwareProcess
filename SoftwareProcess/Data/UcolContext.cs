using Microsoft.EntityFrameworkCore;
using SoftwareProcess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareProcess.Data
{
    public class UcolContext : DbContext
    {

        public UcolContext(DbContextOptions<UcolContext> options) : base(options)
        { }
        public DbSet<LectureAdmin> LectureAdmins { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<TestSchedule> TestSchedules { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }    }
}
