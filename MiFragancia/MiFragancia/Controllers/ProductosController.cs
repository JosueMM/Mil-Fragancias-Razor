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
    public class ProductosController : Controller
    {
        private readonly FraganciaContext _context;
        public IList<Producto> carrito = new List<Producto>();
        public IList<Producto> select;

        public ProductosController(FraganciaContext context)
        {
            _context = context;
            
        }

        [HttpPost]
        public async Task<IActionResult> AddCarritoAsync(int id , int cantidad)
        {
            
            var producto = await _context.Producto
                .Include(p => p.Imagen)
                .Include(p => p.Tipo)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (producto.Cantidad >= cantidad)
            {
                if (Log.carrito == null)
                {
                    Log.carrito = new List<Producto>();
                }
                carrito.Add(producto);
                Log.cantidadProd += cantidad * producto.Precio;

                for (int i = 0; i < cantidad; i++)
                {
                    Log.carrito.Add(producto);
                }
               
                Log.Messajes = "Producto Añadido al carro";
                return RedirectToAction("Index", "Productos");

            }
            else
            {
                Log.Messajes = "Cantidad no disponible";
                return RedirectToAction("Index", "Productos");

            }
            
  
        }

        public async Task<IActionResult> Comprar(int prodRemove)
        {

            var fraganciaContext = _context.Producto.Include(p => p.Imagen).Include(p => p.Tipo);
            carrito = await fraganciaContext.ToListAsync();

            for (int i = 0; i < carrito.Count; i++)
            {
                for (int j = 0; j < Log.carrito.Count; j++)
                {
                    if (Log.carrito[j].ID == carrito[i].ID)
                    {

                        carrito[i].Cantidad -= 1;
                        _context.Update(carrito[i]);
                        await _context.SaveChangesAsync();
                        

                        
                            


                    }
                }
                

            }
            Log.cantidadProd = 0;
            return RedirectToAction("Index", "Productos");
        }



        [HttpPost]
        public async Task<IActionResult> Remove(int prodRemove)
        {
            for (int i = 0; i < Log.carrito.Count; i++)
            {
                if (Log.carrito[i].ID == prodRemove)
                {
                    Log.cantidadProd -= Log.carrito[i].Precio;
                    Log.Messajes = "Se ha eliminado el articulo " + Log.carrito[i].Nombre + " del carrito";
                    Log.carrito.Remove(Log.carrito[i]); 
                }
                
            }
            return RedirectToAction("Index", "Productos");
        }

        // GET: Productos
        public async Task<IActionResult> Index()
        {
         
            var fraganciaContext = _context.Producto.Include(p => p.Imagen).Include(p => p.Tipo);
            return View(await fraganciaContext.ToListAsync());
        }

     

        // GET: Productos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto
                .Include(p => p.Imagen)
                .Include(p => p.Tipo)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // GET: Productos/Create
        public IActionResult Create()
        {
            ViewData["ImagenId"] = new SelectList(_context.Imagen, "ID", "ID");
            ViewData["TipoProductoId"] = new SelectList(_context.TipoProducto, "ID", "ID");
            return View();
        }

        // POST: Productos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nombre,Descripcion,Cantidad,Precio,Activo,TipoProductoId,ImagenId")] Producto producto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ImagenId"] = new SelectList(_context.Imagen, "ID", "ID", producto.ImagenId);
            ViewData["TipoProductoId"] = new SelectList(_context.TipoProducto, "ID", "ID", producto.TipoProductoId);
            return View(producto);
        }

        // GET: Productos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            ViewData["ImagenId"] = new SelectList(_context.Imagen, "ID", "ID", producto.ImagenId);
            ViewData["TipoProductoId"] = new SelectList(_context.TipoProducto, "ID", "ID", producto.TipoProductoId);
            return View(producto);
        }

        // POST: Productos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nombre,Descripcion,Cantidad,Precio,Activo,TipoProductoId,ImagenId")] Producto producto)
        {
            if (id != producto.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoExists(producto.ID))
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
            ViewData["ImagenId"] = new SelectList(_context.Imagen, "ID", "ID", producto.ImagenId);
            ViewData["TipoProductoId"] = new SelectList(_context.TipoProducto, "ID", "ID", producto.TipoProductoId);
            return View(producto);
        }

        // GET: Productos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto
                .Include(p => p.Imagen)
                .Include(p => p.Tipo)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // POST: Productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producto = await _context.Producto.FindAsync(id);
            _context.Producto.Remove(producto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductoExists(int id)
        {
            return _context.Producto.Any(e => e.ID == id);
        }
    }
}
