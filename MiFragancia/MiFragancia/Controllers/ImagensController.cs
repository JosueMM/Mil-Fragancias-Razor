﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        // GET: Imagens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imagen = await _context.Imagen
                .FirstOrDefaultAsync(m => m.ID == id);
            if (imagen == null)
            {
                return NotFound();
            }

            return View(imagen);
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
        public async Task<IActionResult> Create([Bind("ID,ImagenArray,Activo")] Imagen imagen)
        {
            if (ModelState.IsValid)
            {
                _context.Add(imagen);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(imagen);
        }

        // GET: Imagens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imagen = await _context.Imagen.FindAsync(id);
            if (imagen == null)
            {
                return NotFound();
            }
            return View(imagen);
        }

        // POST: Imagens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ImagenArray,Activo")] Imagen imagen)
        {
            if (id != imagen.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(imagen);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImagenExists(imagen.ID))
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
            return View(imagen);
        }

        // GET: Imagens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imagen = await _context.Imagen
                .FirstOrDefaultAsync(m => m.ID == id);
            if (imagen == null)
            {
                return NotFound();
            }

            return View(imagen);
        }

        // POST: Imagens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var imagen = await _context.Imagen.FindAsync(id);
            _context.Imagen.Remove(imagen);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImagenExists(int id)
        {
            return _context.Imagen.Any(e => e.ID == id);
        }
    }
}