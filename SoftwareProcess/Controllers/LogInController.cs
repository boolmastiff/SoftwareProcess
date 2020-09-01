using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoftwareProcess.Data;
using SoftwareProcess.Models;

namespace SoftwareProcess.Controllers
{
    public class LogInController : Controller
    {
        private readonly UcolContext _context;

        public LogInController(UcolContext context) {

            _context = context;
              
        }



        public IActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Authorize(SoftwareProcess.Models.Student model, [Bind("ID,First_name,Surname,Institution,Department,Email_address,LDFTC,Password")] Student student) {

            if (model.ID != student.ID) { 
                
            }

                return View();
        }

    }
}
