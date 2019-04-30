using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WIlliGram.Models;

namespace WIlliGram.Controllers
{
    public class WittersController : Controller
    {
        private readonly WIlliGramContext _context;

        public WittersController(WIlliGramContext context)
        {
            _context = context;
        }

        // GET: Witters
        public async Task<IActionResult> Index()
        {
            return View(await _context.Witter.ToListAsync());
        }

        // GET: Witters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var witter = await _context.Witter
                .FirstOrDefaultAsync(m => m.Id == id);
            if (witter == null)
            {
                return NotFound();
            }

            return View(witter);
        }

        // GET: Witters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Witters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Blah,WroteDate,Likes")] Witter witter)
        {
            if (ModelState.IsValid)
            {
                witter.WroteDate = DateTime.Now;
                _context.Add(witter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(witter);
        }

        // GET: Witters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var witter = await _context.Witter.FindAsync(id);
            if (witter == null)
            {
                return NotFound();
            }
            return View(witter);
        }

        // POST: Witters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Blah,WroteDate,Likes")] Witter witter)
        {
            if (id != witter.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(witter);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WitterExists(witter.Id))
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
            return View(witter);
        }

        // GET: Witters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var witter = await _context.Witter
                .FirstOrDefaultAsync(m => m.Id == id);
            if (witter == null)
            {
                return NotFound();
            }

            return View(witter);
        }

        // POST: Witters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var witter = await _context.Witter.FindAsync(id);
            _context.Witter.Remove(witter);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WitterExists(int id)
        {
            return _context.Witter.Any(e => e.Id == id);
        }
    }
}
