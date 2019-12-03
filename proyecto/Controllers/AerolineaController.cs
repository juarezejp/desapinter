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
    public class AerolineaController : Controller
    {
        private readonly aeropuertoCollectionContext _context;

        public AerolineaController(aeropuertoCollectionContext context)
        {
            _context = context;
        }

        // GET: Aerolinea
        public async Task<IActionResult> Index()
        {
            return View(await _context.Aerolinea.ToListAsync());
        }

        // GET: Aerolinea/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aerolinea = await _context.Aerolinea
                .FirstOrDefaultAsync(m => m.IDAerolinea == id);
            if (aerolinea == null)
            {
                return NotFound();
            }

            return View(aerolinea);
        }

        // GET: Aerolinea/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Aerolinea/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDAerolinea,ruc")] Aerolinea aerolinea)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aerolinea);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aerolinea);
        }

        // GET: Aerolinea/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aerolinea = await _context.Aerolinea.FindAsync(id);
            if (aerolinea == null)
            {
                return NotFound();
            }
            return View(aerolinea);
        }

        // POST: Aerolinea/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDAerolinea,ruc")] Aerolinea aerolinea)
        {
            if (id != aerolinea.IDAerolinea)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aerolinea);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AerolineaExists(aerolinea.IDAerolinea))
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
            return View(aerolinea);
        }

        // GET: Aerolinea/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aerolinea = await _context.Aerolinea
                .FirstOrDefaultAsync(m => m.IDAerolinea == id);
            if (aerolinea == null)
            {
                return NotFound();
            }

            return View(aerolinea);
        }

        // POST: Aerolinea/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aerolinea = await _context.Aerolinea.FindAsync(id);
            _context.Aerolinea.Remove(aerolinea);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AerolineaExists(int id)
        {
            return _context.Aerolinea.Any(e => e.IDAerolinea == id);
        }
    }
}
