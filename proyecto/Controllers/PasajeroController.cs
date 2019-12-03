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
    public class PasajeroController : Controller
    {
        private readonly aeropuertoCollectionContext _context;

        public PasajeroController(aeropuertoCollectionContext context)
        {
            _context = context;
        }

        // GET: Pasajero
        public async Task<IActionResult> Index()
        {
            var aeropuertoCollectionContext = _context.Pasajero.Include(p => p.Pais);
            return View(await aeropuertoCollectionContext.ToListAsync());
        }

        // GET: Pasajero/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pasajero = await _context.Pasajero
                .Include(p => p.Pais)
                .FirstOrDefaultAsync(m => m.IDPasajero == id);
            if (pasajero == null)
            {
                return NotFound();
            }

            return View(pasajero);
        }

        // GET: Pasajero/Create
        public IActionResult Create()
        {
            ViewData["IDPais"] = new SelectList(_context.Set<Pais>(), "IDPais", "nombre");
            return View();
        }

        // POST: Pasajero/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDPasajero,nombre,apaterno,amaterno,tipo_documento,num_documento,fecha_nacimiento,IDPais,telefono,email,clave")] Pasajero pasajero)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pasajero);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDPais"] = new SelectList(_context.Set<Pais>(), "IDPais", "nombre", pasajero.IDPais);
            return View(pasajero);
        }

        // GET: Pasajero/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pasajero = await _context.Pasajero.FindAsync(id);
            if (pasajero == null)
            {
                return NotFound();
            }
            ViewData["IDPais"] = new SelectList(_context.Set<Pais>(), "IDPais", "nombre", pasajero.IDPais);
            return View(pasajero);
        }

        // POST: Pasajero/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDPasajero,nombre,apaterno,amaterno,tipo_documento,num_documento,fecha_nacimiento,IDPais,telefono,email,clave")] Pasajero pasajero)
        {
            if (id != pasajero.IDPasajero)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pasajero);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PasajeroExists(pasajero.IDPasajero))
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
            ViewData["IDPais"] = new SelectList(_context.Set<Pais>(), "IDPais", "nombre", pasajero.IDPais);
            return View(pasajero);
        }

        // GET: Pasajero/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pasajero = await _context.Pasajero
                .Include(p => p.Pais)
                .FirstOrDefaultAsync(m => m.IDPasajero == id);
            if (pasajero == null)
            {
                return NotFound();
            }

            return View(pasajero);
        }

        // POST: Pasajero/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pasajero = await _context.Pasajero.FindAsync(id);
            _context.Pasajero.Remove(pasajero);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PasajeroExists(int id)
        {
            return _context.Pasajero.Any(e => e.IDPasajero == id);
        }
    }
}
