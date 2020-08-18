using Microsoft.EntityFrameworkCore;
using SoftwareProcess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareProcess.Controllers
{
    public class LectureAdminContext : DbContext
    {
        public LectureAdminContext(DbContextOptions<LectureAdminContext> options) : base(options)
        { }

        public DbSet<LectureAdmin> LectureAdmins { get; set; }
    }
}
