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
            var proyectMVCContext = _context.Producto.Include(r => r.Tipo).Include(r => r.Imagen);
            return View(await proyectMVCContext.ToListAsync());
        }

        // GET: Reunion/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productoModel = await _context.Producto
                .Include(r => r.Tipo)
                .Include(r => r.Imagen)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (productoModel == null)
            {
                return NotFound();
            }

            return View(productoModel);
        }

        // GET: Reunion/Create
        public IActionResult Create()
        {
            ViewData["TipoProductoId"] = new SelectList(_context.TipoProducto, "Id", "Nombre");
            ViewData["ImagenId"] = new SelectList(_context.Imagen, "Id", "ImagenArray");
            return View();
        }

        // POST: Reunion/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Descripcion,Cantidad,Precio,Activo,TipoProductoId,ImagenId")] ProductoModel productoModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productoModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TipoProductoId"] = new SelectList(_context.Producto, "Id", "Precio", productoModel.TipoProductoId);
            ViewData["ImagenId"] = new SelectList(_context.Set<UsuarioModel>(), "Id", "Nombre", productoModel.ImagenId);
            return View(productoModel);
        }

        // GET: Reunion/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productoModel = await _context.Producto.SingleOrDefaultAsync(m => m.Id == id);
            if (productoModel == null)
            {
                return NotFound();
            }
            ViewData["TipoProductoId"] = new SelectList(_context.TipoProducto, "Id", "Precio", productoModel.TipoProductoId);
            ViewData["ImagenId"] = new SelectList(_context.Imagen, "Id", "Nombre", productoModel.ImagenId);
            return View(productoModel);
        }

        // POST: Reunion/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Descripcion,Cantidad,Precio,Activo,TipoProductoId,ImagenId")] TipoProductoModel productoModel)
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
             ViewData["TipoProductoId"] = new SelectList(_context.TipoProducto, "Id", "Precio", productoModel.Id);
            ViewData["ImagenId"] = new SelectList(_context.Imagen, "Id", "Nombre", productoModel.Id);
            return View(tipoProductoModel);
        }

        // GET: Reunion/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productoModel = await _context.Producto
                .Include(r => r.Tipo)
                .Include(r => r.Imagen)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (productoModel == null)
            {
                return NotFound();
            }

            return View(productoModel);
        }

        // POST: Reunion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productoModel = await _context.Producto.SingleOrDefaultAsync(m => m.Id == id);
            _context.Producto.Remove(productoModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductoModelExists(int id)
        {
            return _context.Producto.Any(e => e.Id == id);
        }
    }
}
