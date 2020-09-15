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


        public async Task<IActionResult> AdminLogin(int id, string password) {
            var LectureAdmin = await _context.LectureAdmins
                .FirstOrDefaultAsync(m => m.ID == id);
            return View(LectureAdmin);
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
            // if id or password not entered, returns to index, with added error message
            if (id == 0 || password == null)
            {
                return RedirectToAction(nameof(Index));
            }
            // declares Student variable, goes into UcolContext.Students database, finds and returns object where ID's match
            var Student = await _context.Students
                .FirstOrDefaultAsync(m => m.ID == id);

            // if No result found when declaring Student Variable. it will run this
            if (Student == null) {
                // declares LectureAdmin variable, goes into UcolContext.LectureAdmin database, finds and returns object where ID's match
                var LectureAdmin = await _context.LectureAdmins
                .FirstOrDefaultAsync(m => m.ID == id);

                // checks to see if id & password entered match database
                if (id == LectureAdmin.ID && password == LectureAdmin.Password)
                {
                    return RedirectToAction(nameof(AdminLogin), new {id = LectureAdmin.ID, password = LectureAdmin.Password});
                    //return View(LectureAdmin);
                }
                else
                {
                    //returns to Index page
                    return RedirectToAction(nameof(Index));

                }

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
