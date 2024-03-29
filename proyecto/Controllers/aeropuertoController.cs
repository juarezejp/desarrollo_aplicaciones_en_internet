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
    public class AeropuertoController : Controller
    {
        private readonly aeropuertoCollectionContext _context;

        public AeropuertoController(aeropuertoCollectionContext context)
        {
            _context = context;
        }

        // GET: Aeropuerto
        public async Task<IActionResult> Index()
        {
            var aeropuertoCollectionContext = _context.Aeropuerto.Include(a => a.Pais);
            return View(await aeropuertoCollectionContext.ToListAsync());
        }

        // GET: Aeropuerto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aeropuerto = await _context.Aeropuerto
                .Include(a => a.Pais)
                .FirstOrDefaultAsync(m => m.IDAeropuerto == id);
            if (aeropuerto == null)
            {
                return NotFound();
            }

            return View(aeropuerto);
        }

        // GET: Aeropuerto/Create
        public IActionResult Create()
        {
            ViewData["IDPais"] = new SelectList(_context.Set<Pais>(), "IDPais", "nombre");
            return View();
        }

        // POST: Aeropuerto/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDAeropuerto,nombre,IDPais")] Aeropuerto aeropuerto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aeropuerto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IDPais"] = new SelectList(_context.Set<Pais>(), "IDPais", "nombre", aeropuerto.IDPais);
            return View(aeropuerto);
        }

        // GET: Aeropuerto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aeropuerto = await _context.Aeropuerto.FindAsync(id);
            if (aeropuerto == null)
            {
                return NotFound();
            }
            ViewData["IDPais"] = new SelectList(_context.Set<Pais>(), "IDPais", "nombre", aeropuerto.IDPais);
            return View(aeropuerto);
        }

        // POST: Aeropuerto/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDAeropuerto,nombre,IDPais")] Aeropuerto aeropuerto)
        {
            if (id != aeropuerto.IDAeropuerto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aeropuerto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AeropuertoExists(aeropuerto.IDAeropuerto))
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
            ViewData["IDPais"] = new SelectList(_context.Set<Pais>(), "IDPais", "nombre", aeropuerto.IDPais);
            return View(aeropuerto);
        }

        // GET: Aeropuerto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aeropuerto = await _context.Aeropuerto
                .Include(a => a.Pais)
                .FirstOrDefaultAsync(m => m.IDAeropuerto == id);
            if (aeropuerto == null)
            {
                return NotFound();
            }

            return View(aeropuerto);
        }

        // POST: Aeropuerto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aeropuerto = await _context.Aeropuerto.FindAsync(id);
            _context.Aeropuerto.Remove(aeropuerto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AeropuertoExists(int id)
        {
            return _context.Aeropuerto.Any(e => e.IDAeropuerto == id);
        }
    }
}
