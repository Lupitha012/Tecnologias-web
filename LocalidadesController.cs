using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ActividadComplementaria.Models;

namespace ActividadComplementaria.Controllers
{
    public class LocalidadesController : Controller
    {
        private readonly ActividadComplementariaContext _context;

        public LocalidadesController(ActividadComplementariaContext context)
        {
            _context = context;
        }

        // GET: Localidades
        public async Task<IActionResult> Index()
        {
            return View(await _context.Localidades.ToListAsync());
        }

        // GET: Localidades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var localidades = await _context.Localidades
                .SingleOrDefaultAsync(m => m.id_localidades == id);
            if (localidades == null)
            {
                return NotFound();
            }

            return View(localidades);
        }

        // GET: Localidades/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Localidades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_localidades,localidad,municipio_id_municipio")] Localidades localidades)
        {
            if (ModelState.IsValid)
            {
                _context.Add(localidades);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(localidades);
        }

        // GET: Localidades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var localidades = await _context.Localidades.SingleOrDefaultAsync(m => m.id_localidades == id);
            if (localidades == null)
            {
                return NotFound();
            }
            return View(localidades);
        }

        // POST: Localidades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_localidades,localidad,municipio_id_municipio")] Localidades localidades)
        {
            if (id != localidades.id_localidades)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(localidades);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocalidadesExists(localidades.id_localidades))
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
            return View(localidades);
        }

        // GET: Localidades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var localidades = await _context.Localidades
                .SingleOrDefaultAsync(m => m.id_localidades == id);
            if (localidades == null)
            {
                return NotFound();
            }

            return View(localidades);
        }

        // POST: Localidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var localidades = await _context.Localidades.SingleOrDefaultAsync(m => m.id_localidades == id);
            _context.Localidades.Remove(localidades);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocalidadesExists(int id)
        {
            return _context.Localidades.Any(e => e.id_localidades == id);
        }
    }
}
