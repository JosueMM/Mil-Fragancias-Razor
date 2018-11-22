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
    public class CarritoController : Controller
    {
        private readonly ProyectMVCContext _context;

        public CarritoController(ProyectMVCContext context)
        {
            _context = context;
        }

        // GET: Support
        public async Task<IActionResult> Index()
        {
            var proyectMVCContext = _context.Carrito.Include(s => s.Usuario);
            return View(await proyectMVCContext.ToListAsync());
        }

        // GET: Support/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supportModel = await _context.Carrito
                .Include(s => s.Usuario)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (supportModel == null)
            {
                return NotFound();
            }

            return View(supportModel);
        }

        // GET: Support/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Carrito, "Id", "Nombre");
            return View();
        }

        // POST: Support/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Problema,Detalle,Estado,ClienteId")] CarritoModel supportModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(supportModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Carrito, "Id", "Nombre", supportModel.Usuario);
            return View(supportModel);
        }

        // GET: Support/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supportModel = await _context.Carrito.SingleOrDefaultAsync(m => m.Id == id);
            if (supportModel == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Carrito, "Id", "Nombre", supportModel.Usuario);
            return View(supportModel);
        }

        // POST: Support/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Problema,Detalle,Estado,ClienteId")] CarritoModel supportModel)
        {
            if (id != supportModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(supportModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SupportModelExists(supportModel.Id))
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
            ViewData["ClienteId"] = new SelectList(_context.Carrito, "Id", "Nombre", supportModel.Usuario);
            return View(supportModel);
        }

        // GET: Support/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supportModel = await _context.Carrito
                .Include(s => s.Usuario)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (supportModel == null)
            {
                return NotFound();
            }

            return View(supportModel);
        }

        // POST: Support/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carrito = await _context.Carrito.SingleOrDefaultAsync(m => m.Id == id);
            _context.Carrito.Remove(carrito);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SupportModelExists(int id)
        {
            return _context.Carrito.Any(e => e.Id == id);
        }
    }
}
