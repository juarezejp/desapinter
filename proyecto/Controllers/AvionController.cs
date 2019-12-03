using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using proyecto.Data;
using proyecto.Models;

namespace proyecto.Controllers
{
    public class AvionController : Controller
    {
        private readonly aeropuertoCollectionContext _context;

        public AvionController(aeropuertoCollectionContext context)
        {
            _context = context;
        }

        // GET: Avion
        public async Task<IActionResult> Index()
        {
            var aeropuertoCollectionContext = _context.Avion.Include(a => a.Aerolinea);
            return View(await aeropuertoCollectionContext.ToListAsync());
        }

        // GET: Avion/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var avion = await _context.Avion
                .Include(a => a.Aerolinea)
                .FirstOrDefaultAsync(m => m.IDAvion == id);
            if (avion == null)
            {
                return NotFound();
            }

            return View(avion);
        }

        // GET: Avion/Create
        public IActionResult Create()
        {
            ViewData["IDAerolinea"] = new SelectList(_context.Set<Aerolinea>(), "IDAerolinea", "IDAerolinea");
            return View();
        }

        // POST: Avion/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDAvion,IDAerolinea,fabricante,tipo,capacidad")] Avion avion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(avion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDAerolinea"] = new SelectList(_context.Set<Aerolinea>(), "IDAerolinea", "IDAerolinea", avion.IDAerolinea);
            return View(avion);
        }

        // GET: Avion/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var avion = await _context.Avion.FindAsync(id);
            if (avion == null)
            {
                return NotFound();
            }
            ViewData["IDAerolinea"] = new SelectList(_context.Set<Aerolinea>(), "IDAerolinea", "IDAerolinea", avion.IDAerolinea);
            return View(avion);
        }

        // POST: Avion/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDAvion,IDAerolinea,fabricante,tipo,capacidad")] Avion avion)
        {
            if (id != avion.IDAvion)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(avion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AvionExists(avion.IDAvion))
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
            ViewData["IDAerolinea"] = new SelectList(_context.Set<Aerolinea>(), "IDAerolinea", "IDAerolinea", avion.IDAerolinea);
            return View(avion);
        }

        // GET: Avion/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var avion = await _context.Avion
                .Include(a => a.Aerolinea)
                .FirstOrDefaultAsync(m => m.IDAvion == id);
            if (avion == null)
            {
                return NotFound();
            }

            return View(avion);
        }

        // POST: Avion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var avion = await _context.Avion.FindAsync(id);
            _context.Avion.Remove(avion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AvionExists(int id)
        {
            return _context.Avion.Any(e => e.IDAvion == id);
        }
    }
}
