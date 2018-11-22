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
    public class ProductoController : Controller
    {
        private readonly ProyectMVCContext _context;

        public ProductoController(ProyectMVCContext context)
        {
            _context = context;
        }

        // GET: Reunion
        public async Task<IActionResult> Index()
        {
            var proyectMVCContext = _context.Producto.Include(r => r.Nombre).Include(r => r.Tipo);
            return View(await proyectMVCContext.ToListAsync());
        }

        // GET: Reunion/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reunionModel = await _context.Producto
                .Include(r => r.Nombre)
                .Include(r => r.Tipo)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (reunionModel == null)
            {
                return NotFound();
            }

            return View(reunionModel);
        }

        // GET: Reunion/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Producto, "Id", "Nombre");
            ViewData["UsuarioId"] = new SelectList(_context.Set<UsuarioModel>(), "Id", "Nombre");
            return View();
        }

        // POST: Reunion/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo,Dia,UsuarioId,presencial,ClienteId")] ProductoModel reunionModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reunionModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Producto, "Id", "Nombre", reunionModel.TipoProductoId);
           // ViewData["UsuarioId"] = new SelectList(_context.Set<UsuarioModel>(), "Id", "Nombre", reunionModel.UsuarioId);
            return View(reunionModel);
        }

        // GET: Reunion/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reunionModel = await _context.Producto.SingleOrDefaultAsync(m => m.Id == id);
            if (reunionModel == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Producto, "Id", "Nombre", reunionModel.TipoProductoId);
           // ViewData["UsuarioId"] = new SelectList(_context.Set<UsuarioModel>(), "Id", "Nombre", reunionModel.UsuarioId);
            return View(reunionModel);
        }

        // POST: Reunion/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,Dia,UsuarioId,presencial,ClienteId")] TipoProductoModel reunionModel)
        {
            if (id != reunionModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reunionModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReunionModelExists(reunionModel.Id))
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
            ViewData["ClienteId"] = new SelectList(_context.Producto, "Id", "Nombre", reunionModel.ProductoId);
          //  ViewData["UsuarioId"] = new SelectList(_context.Set<UsuarioModel>(), "Id", "Nombre", reunionModel.UsuarioId);
            return View(reunionModel);
        }

        // GET: Reunion/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reunionModel = await _context.Producto
                .Include(r => r.Nombre)
                .Include(r => r.Tipo)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (reunionModel == null)
            {
                return NotFound();
            }

            return View(reunionModel);
        }

        // POST: Reunion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reunionModel = await _context.Producto.SingleOrDefaultAsync(m => m.Id == id);
            _context.Producto.Remove(reunionModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReunionModelExists(int id)
        {
            return _context.Producto.Any(e => e.Id == id);
        }
    }
}
