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
    public class NPTL0128sController : Controller
    {
        private readonly ApplicationContext _context;

        public NPTL0128sController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: NPTL0128s
        public async Task<IActionResult> Index()
        {
            return View(await _context.NPTL0128.ToListAsync());
        }

        // GET: NPTL0128s/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nPTL0128 = await _context.NPTL0128
                .FirstOrDefaultAsync(m => m.NPTLId == id);
            if (nPTL0128 == null)
            {
                return NotFound();
            }

            return View(nPTL0128);
        }

        // GET: NPTL0128s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NPTL0128s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NPTLId,NPTLName,NPTLGenre")] NPTL0128 nPTL0128)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nPTL0128);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nPTL0128);
        }

        // GET: NPTL0128s/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nPTL0128 = await _context.NPTL0128.FindAsync(id);
            if (nPTL0128 == null)
            {
                return NotFound();
            }
            return View(nPTL0128);
        }

        // POST: NPTL0128s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NPTLId,NPTLName,NPTLGenre")] NPTL0128 nPTL0128)
        {
            if (id != nPTL0128.NPTLId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nPTL0128);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NPTL0128Exists(nPTL0128.NPTLId))
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
            return View(nPTL0128);
        }

        // GET: NPTL0128s/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nPTL0128 = await _context.NPTL0128
                .FirstOrDefaultAsync(m => m.NPTLId == id);
            if (nPTL0128 == null)
            {
                return NotFound();
            }

            return View(nPTL0128);
        }

        // POST: NPTL0128s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nPTL0128 = await _context.NPTL0128.FindAsync(id);
            _context.NPTL0128.Remove(nPTL0128);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NPTL0128Exists(int id)
        {
            return _context.NPTL0128.Any(e => e.NPTLId == id);
        }
    }
}
