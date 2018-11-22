using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectMVC.Models;

namespace ProyectMVC.Controllers
{
    public class ImagenController : Controller
    {
        private readonly ProyectMVCContext _context;

        public ImagenController(ProyectMVCContext context)
        {
            _context = context;
        }

        // GET: Contacto
        public async Task<IActionResult> Index()
        {
            var proyectMVCContext = _context.Imagen.Include(c => c.Id);
            return View(await proyectMVCContext.ToListAsync());
        }

        // GET: Contacto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactoModel = await _context.Imagen
                .Include(c => c.Id)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (contactoModel == null)
            {
                return NotFound();
            }

            return View(contactoModel);
        }

        // GET: Contacto/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Imagen, "Id", "Nombre");
            return View();
        }

        // POST: Contacto/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Apellido,Correo,Numero,Puesto,ClienteId")] ImagenModel contactoModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactoModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Imagen, "Id", "Nombre", contactoModel.Id);
            return View(contactoModel);
        }

        // GET: Contacto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactoModel = await _context.Imagen.SingleOrDefaultAsync(m => m.Id == id);
            if (contactoModel == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Imagen, "Id", "Nombre", contactoModel.Id);
            return View(contactoModel);
        }

        // POST: Contacto/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Apellido,Correo,Numero,Puesto,ClienteId")] ImagenModel contactoModel)
        {
            if (id != contactoModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactoModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactoModelExists(contactoModel.Id))
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
            ViewData["ClienteId"] = new SelectList(_context.Imagen, "Id", "Nombre", contactoModel.Id);
            return View(contactoModel);
        }

        // GET: Contacto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactoModel = await _context.Imagen
                .Include(c => c.Id)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (contactoModel == null)
            {
                return NotFound();
            }

            return View(contactoModel);
        }

        // POST: Contacto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contactoModel = await _context.Imagen.SingleOrDefaultAsync(m => m.Id == id);
            _context.Imagen.Remove(contactoModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactoModelExists(int id)
        {
            return _context.Imagen.Any(e => e.Id == id);
        }
    }
}
