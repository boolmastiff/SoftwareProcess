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
    public class TestSchedulesController : Controller
    {
        private readonly UcolContext _context;

        public TestSchedulesController(UcolContext context)
        {
            _context = context;
        }

        // GET: TestSchedules
        public async Task<IActionResult> Index()
        {
            return View(await _context.TestSchedules.ToListAsync());
        }

        // GET: TestSchedules/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testSchedule = await _context.TestSchedules
                .FirstOrDefaultAsync(m => m.ID == id);
            if (testSchedule == null)
            {
                return NotFound();
            }

            return View(testSchedule);
        }

        // GET: TestSchedules/Create
        // The Class id is passed to this create function, so that the admins can easily link a test schedule to a class without needing to know its ID
        public IActionResult Create(int? id)
        {
            ViewBag.Message = id;
            return View();
        }

        // POST: TestSchedules/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ClassID,StartTime,Duration")] TestSchedule testSchedule)
        {
            if (ModelState.IsValid)
            {
                _context.Add(testSchedule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(testSchedule);
        }

        // GET: TestSchedules/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testSchedule = await _context.TestSchedules.FindAsync(id);
            if (testSchedule == null)
            {
                return NotFound();
            }
            return View(testSchedule);
        }

        // POST: TestSchedules/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ClassID,StartTime,Duration")] TestSchedule testSchedule)
        {
            if (id != testSchedule.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(testSchedule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TestScheduleExists(testSchedule.ID))
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
            return View(testSchedule);
        }

        // GET: TestSchedules/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testSchedule = await _context.TestSchedules
                .FirstOrDefaultAsync(m => m.ID == id);
            if (testSchedule == null)
            {
                return NotFound();
            }

            return View(testSchedule);
        }

        // POST: TestSchedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var testSchedule = await _context.TestSchedules.FindAsync(id);
            _context.TestSchedules.Remove(testSchedule);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TestScheduleExists(int id)
        {
            return _context.TestSchedules.Any(e => e.ID == id);
        }
    }
}
