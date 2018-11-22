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
    public class TipoProductoController : Controller
    {
        private readonly ProyectMVCContext _context;

        public TipoProductoController(ProyectMVCContext context)
        {
            _context = context;
        }

        // GET: Sector
        public async Task<IActionResult> Index()
        {
var proyectMVCContext = _context.TipoProducto.Include(r => r.Producto).Include(r => r.Usuario);
            return View(await proyectMVCContext.ToListAsync());        }

        // GET: Sector/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoProductoModel = await _context.TipoProducto
               .Include(r => r.Producto)
                .Include(r => r.Usuario)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (tipoProductoModel == null)
            {
                return NotFound();
            }

            return View(tipoProductoModel);
        }

        // GET: Sector/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sector/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UsuarioId,ProductoId,Cantidad,Precio")] TipoProductoModel tipoProductoModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoProductoModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductoId"] = new SelectList(_context.TipoProducto, "Id", "Nombre", tipoProductoModel.ProductoId);
            ViewData["UsuarioId"] = new SelectList(_context.Set<UsuarioModel>(), "Id", "Nombre", tipoProductoModel.UsuarioId);
            
            return View(tipoProductoModel);
        }

        // GET: Sector/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoProductoModel = await _context.TipoProducto.SingleOrDefaultAsync(m => m.Id == id);
            if (tipoProductoModel == null)
            {
                return NotFound();
            }
             ViewData["ProductoId"] = new SelectList(_context.TipoProducto, "Id", "Precio", tipoProductoModel.ProductoId);
            ViewData["UsuarioId"] = new SelectList(_context.Set<UsuarioModel>(), "Id", "Nombre", tipoProductoModel.UsuarioId);
            return View(tipoProductoModel);
        }

        // POST: Sector/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,[Bind("Id,UsuarioId,ProductoId,Cantidad,Precio")] TipoProductoModel tipoProductoModel)
        {
            if (id != tipoProductoModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoProductoModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoProductoModelExists(tipoProductoModel.Id))
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
            return View(tipoProductoModel);
        }

        // GET: Sector/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sectorModel = await _context.TipoProducto
                .SingleOrDefaultAsync(m => m.Id == id);
            if (sectorModel == null)
            {
                return NotFound();
            }

            return View(sectorModel);
        }

        // POST: Sector/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sectorModel = await _context.TipoProducto.SingleOrDefaultAsync(m => m.Id == id);
            _context.TipoProducto.Remove(sectorModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoProductoModelExists(int id)
        {
            return _context.TipoProducto.Any(e => e.Id == id);
        }
    }
}
