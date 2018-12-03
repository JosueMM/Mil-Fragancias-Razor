using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.DotNet.PlatformAbstractions;
using Microsoft.EntityFrameworkCore;
using MiFragancia.Models;


namespace MiFragancia.Controllers
{
    public class ImagensController : Controller
    {
        private readonly FraganciaContext _context;

        public ImagensController(FraganciaContext context)
        {
            _context = context;
        }

        // GET: Imagens
        public async Task<IActionResult> Index()
        {
            return View(await _context.Imagen.ToListAsync());
        }

        [HttpPost]
        public async Task<Imagens> getImagen(int id)
        {
            var imagens = await _context.Imagen
            .FirstOrDefaultAsync(m => m.ID == id);

            return imagens; 
        }

        // GET: Imagens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imagens = await _context.Imagen
                .FirstOrDefaultAsync(m => m.ID == id);
            if (imagens == null)
            {
                return NotFound();
            }

            return View(imagens);
        }

        public async Task<IActionResult> Add(Imagens imagenModel)
        {

            string filename = Path.GetFileNameWithoutExtension(imagenModel.imageFile.FileName);

            string etension = Path.GetExtension(imagenModel.imageFile.FileName);
            filename = filename + DateTime.Now.ToString("yymmssfff") + etension;
            Log.imagen = filename;
            imagenModel.ImagePath = "~/images/" + filename;
            filename = Path.Combine("wwwroot/images", filename);
            using (var fileStream = new FileStream(filename, FileMode.Create))
            {
                await imagenModel.imageFile.CopyToAsync(fileStream);
            }

            
            Log.path = imagenModel.imageFile;
            Log.imagen = Log.imagen.Replace('\\', '/');

            return RedirectToAction("Create", "Imagens");
        }

      


        // GET: Imagens/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Imagens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nombre,ImagePath,Activo")] Imagens imagens)
        {
            if (ModelState.IsValid)
            {
                imagens.imageFile = Log.path;
                _context.Add(imagens);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(imagens);
        }

        // GET: Imagens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imagens = await _context.Imagen.FindAsync(id);
            if (imagens == null)
            {
                return NotFound();
            }
            return View(imagens);
        }

        // POST: Imagens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nombre,ImagePath,Activo")] Imagens imagens)
        {
            if (id != imagens.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(imagens);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImagensExists(imagens.ID))
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
            return View(imagens);
        }

        // GET: Imagens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imagens = await _context.Imagen
                .FirstOrDefaultAsync(m => m.ID == id);
            if (imagens == null)
            {
                return NotFound();
            }

            return View(imagens);
        }

        // POST: Imagens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var imagens = await _context.Imagen.FindAsync(id);
            _context.Imagen.Remove(imagens);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImagensExists(int id)
        {
            return _context.Imagen.Any(e => e.ID == id);
        }
    }
}
