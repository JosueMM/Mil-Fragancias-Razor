using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MiFragancia.Models;

namespace MiFragancia.Controllers
{
    public class CarritoesController : Controller
    {
        private readonly FraganciaContext _context;

        public CarritoesController(FraganciaContext context)
        {
            _context = context;
        }

        // GET: Carritoes
        public async Task<IActionResult> Index()
        {
            var fraganciaContext = _context.Carrito.Include(c => c.TipoProducto).Include(c => c.Usuario);
            return View(await fraganciaContext.ToListAsync());
        }

        // GET: Carritoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrito = await _context.Carrito
                .Include(c => c.TipoProducto)
                .Include(c => c.Usuario)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (carrito == null)
            {
                return NotFound();
            }

            return View(carrito);
        }

        // GET: Carritoes/Create
        public IActionResult Create()
        {
            ViewData["TipoProductoId"] = new SelectList(_context.TipoProducto, "ID", "ID");
            ViewData["UsuarioId"] = new SelectList(_context.UsuarioModel, "ID", "ID");
            return View();
        }

        // POST: Carritoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,UsuarioId,TipoProductoId,Cantidad,Precio")] Carrito carrito)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carrito);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TipoProductoId"] = new SelectList(_context.TipoProducto, "ID", "ID", carrito.TipoProductoId);
            ViewData["UsuarioId"] = new SelectList(_context.UsuarioModel, "ID", "ID", carrito.UsuarioId);
            return View(carrito);
        }

        // GET: Carritoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrito = await _context.Carrito.FindAsync(id);
            if (carrito == null)
            {
                return NotFound();
            }
            ViewData["TipoProductoId"] = new SelectList(_context.TipoProducto, "ID", "ID", carrito.TipoProductoId);
            ViewData["UsuarioId"] = new SelectList(_context.UsuarioModel, "ID", "ID", carrito.UsuarioId);
            return View(carrito);
        }

        // POST: Carritoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,UsuarioId,TipoProductoId,Cantidad,Precio")] Carrito carrito)
        {
            if (id != carrito.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carrito);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarritoExists(carrito.ID))
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
            ViewData["TipoProductoId"] = new SelectList(_context.TipoProducto, "ID", "ID", carrito.TipoProductoId);
            ViewData["UsuarioId"] = new SelectList(_context.UsuarioModel, "ID", "ID", carrito.UsuarioId);
            return View(carrito);
        }

        // GET: Carritoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrito = await _context.Carrito
                .Include(c => c.TipoProducto)
                .Include(c => c.Usuario)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (carrito == null)
            {
                return NotFound();
            }

            return View(carrito);
        }

        // POST: Carritoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carrito = await _context.Carrito.FindAsync(id);
            _context.Carrito.Remove(carrito);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarritoExists(int id)
        {
            return _context.Carrito.Any(e => e.ID == id);
        }
    }
}
