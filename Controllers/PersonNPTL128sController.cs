using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenPhuongThuyLinh128.Models;

namespace NguyenPhuongThuyLinh128.Controllers
{
    public class PersonNPTL128sController : Controller
    {
        private readonly ApplicationContext _context;

        public PersonNPTL128sController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: PersonNPTL128s
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonNPTL128.ToListAsync());
        }

        // GET: PersonNPTL128s/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNPTL128 = await _context.PersonNPTL128
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personNPTL128 == null)
            {
                return NotFound();
            }

            return View(personNPTL128);
        }

        // GET: PersonNPTL128s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonNPTL128s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId,PersonName")] PersonNPTL128 personNPTL128)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personNPTL128);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personNPTL128);
        }

        // GET: PersonNPTL128s/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNPTL128 = await _context.PersonNPTL128.FindAsync(id);
            if (personNPTL128 == null)
            {
                return NotFound();
            }
            return View(personNPTL128);
        }

        // POST: PersonNPTL128s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PersonId,PersonName")] PersonNPTL128 personNPTL128)
        {
            if (id != personNPTL128.PersonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personNPTL128);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonNPTL128Exists(personNPTL128.PersonId))
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
            return View(personNPTL128);
        }

        // GET: PersonNPTL128s/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNPTL128 = await _context.PersonNPTL128
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personNPTL128 == null)
            {
                return NotFound();
            }

            return View(personNPTL128);
        }

        // POST: PersonNPTL128s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personNPTL128 = await _context.PersonNPTL128.FindAsync(id);
            _context.PersonNPTL128.Remove(personNPTL128);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonNPTL128Exists(int id)
        {
            return _context.PersonNPTL128.Any(e => e.PersonId == id);
        }
    }
}
