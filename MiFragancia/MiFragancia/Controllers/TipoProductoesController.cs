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
    public class TipoProductoesController : Controller
    {
        private readonly FraganciaContext _context;

        public TipoProductoesController(FraganciaContext context)
        {
            _context = context;
        }

        // GET: TipoProductoes
        public async Task<IActionResult> Index()
        {
            var fraganciaContext = _context.TipoProducto.Include(t => t.Producto).Include(t => t.Usuario);
            return View(await fraganciaContext.ToListAsync());
        }

        // GET: TipoProductoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoProducto = await _context.TipoProducto
                .Include(t => t.Producto)
                .Include(t => t.Usuario)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (tipoProducto == null)
            {
                return NotFound();
            }

            return View(tipoProducto);
        }

        // GET: TipoProductoes/Create
        public IActionResult Create()
        {
            ViewData["ProductoId"] = new SelectList(_context.Producto, "ID", "ID");
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "ID", "ID");
            return View();
        }

        // POST: TipoProductoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,UsuarioId,ProductoId,Cantidad,Precio")] TipoProducto tipoProducto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoProducto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductoId"] = new SelectList(_context.Producto, "ID", "ID", tipoProducto.ProductoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "ID", "ID", tipoProducto.UsuarioId);
            return View(tipoProducto);
        }

        // GET: TipoProductoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoProducto = await _context.TipoProducto.FindAsync(id);
            if (tipoProducto == null)
            {
                return NotFound();
            }
            ViewData["ProductoId"] = new SelectList(_context.Producto, "ID", "ID", tipoProducto.ProductoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "ID", "ID", tipoProducto.UsuarioId);
            return View(tipoProducto);
        }

        // POST: TipoProductoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,UsuarioId,ProductoId,Cantidad,Precio")] TipoProducto tipoProducto)
        {
            if (id != tipoProducto.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoProducto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoProductoExists(tipoProducto.ID))
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
            ViewData["ProductoId"] = new SelectList(_context.Producto, "ID", "ID", tipoProducto.ProductoId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuario, "ID", "ID", tipoProducto.UsuarioId);
            return View(tipoProducto);
        }

        // GET: TipoProductoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoProducto = await _context.TipoProducto
                .Include(t => t.Producto)
                .Include(t => t.Usuario)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (tipoProducto == null)
            {
                return NotFound();
            }

            return View(tipoProducto);
        }

        // POST: TipoProductoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoProducto = await _context.TipoProducto.FindAsync(id);
            _context.TipoProducto.Remove(tipoProducto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoProductoExists(int id)
        {
            return _context.TipoProducto.Any(e => e.ID == id);
        }
    }
}
