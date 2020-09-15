using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SoftwareProcess.Data;
using SoftwareProcess.Models;

namespace SoftwareProcess.Controllers
{
    public class LectureAdminsController : Controller
    {
        private readonly UcolContext _context;

        public LectureAdminsController(UcolContext context)
        {
            _context = context;
        }

        // GET: LectureAdmins
        public async Task<IActionResult> Index()
        {
            return View(await _context.LectureAdmins.ToListAsync());
        }

        // GET: LectureAdmins/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lectureAdmin = await _context.LectureAdmins
                .FirstOrDefaultAsync(m => m.ID == id);
            if (lectureAdmin == null)
            {
                return NotFound();
            }

            return View(lectureAdmin);
        }

        // GET: LectureAdmins/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LectureAdmins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Password,DOB,Phone")] LectureAdmin lectureAdmin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lectureAdmin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lectureAdmin);
        }

        // GET: LectureAdmins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lectureAdmin = await _context.LectureAdmins.FindAsync(id);
            if (lectureAdmin == null)
            {
                return NotFound();
            }
            return View(lectureAdmin);
        }

        // POST: LectureAdmins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Password,DOB,Phone")] LectureAdmin lectureAdmin)
        {
            if (id != lectureAdmin.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lectureAdmin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LectureAdminExists(lectureAdmin.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(lectureAdmin);
        }

        // GET: LectureAdmins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lectureAdmin = await _context.LectureAdmins
                .FirstOrDefaultAsync(m => m.ID == id);
            if (lectureAdmin == null)
            {
                return NotFound();
            }

            return View(lectureAdmin);
        }

        // POST: LectureAdmins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lectureAdmin = await _context.LectureAdmins.FindAsync(id);
            _context.LectureAdmins.Remove(lectureAdmin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LectureAdminExists(int id)
        {
            return _context.LectureAdmins.Any(e => e.ID == id);
        }
    }
}
