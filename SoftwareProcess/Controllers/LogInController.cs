using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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
        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Authorize() {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Authorize(int id, string password) {

            //    var Student = await _context.Students.FindAsync(id);
            
                var Student = await _context.Students
                .FirstOrDefaultAsync(m => m.ID == id);
            if (Student == null) {
                return RedirectToAction(nameof(Index));
            }

            else if (id == Student.ID && password == Student.Password)
            {
                return View(Student);
            }
            else {
                return RedirectToAction(nameof(Index));

            }
        }

    }
}
