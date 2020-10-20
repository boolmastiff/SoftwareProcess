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
    public class StudentClassesController : Controller
    {
        private readonly UcolContext _context;

        public StudentClassesController(UcolContext context)
        {
            _context = context;
        }

        // GET: StudentClasses
        public async Task<IActionResult> Index()
        {
            return View(await _context.StudentClasses.ToListAsync());
        }

        // GET: StudentClasses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentClass = await _context.StudentClasses
                .FirstOrDefaultAsync(m => m.ID == id);
            if (studentClass == null)
            {
                return NotFound();
            }

            return View(studentClass);
        }

        // GET: StudentClasses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StudentClasses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ClassID,StudentID")] StudentClass studentClass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentClass);
        }

        // GET: StudentClasses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentClass = await _context.StudentClasses.FindAsync(id);
            if (studentClass == null)
            {
                return NotFound();
            }
            return View(studentClass);
        }

        // POST: StudentClasses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ClassID,StudentID")] StudentClass studentClass)
        {
            if (id != studentClass.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentClass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentClassExists(studentClass.ID))
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
            return View(studentClass);
        }

        // GET: StudentClasses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentClass = await _context.StudentClasses
                .FirstOrDefaultAsync(m => m.ID == id);
            if (studentClass == null)
            {
                return NotFound();
            }

            return View(studentClass);
        }

        // POST: StudentClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentClass = await _context.StudentClasses.FindAsync(id);
            _context.StudentClasses.Remove(studentClass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentClassExists(int id)
        {
            return _context.StudentClasses.Any(e => e.ID == id);
        }
    }
}
