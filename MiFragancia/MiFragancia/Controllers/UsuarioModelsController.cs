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
    public class UsuarioModelsController : Controller
    {
        private readonly FraganciaContext _context;
        private string pass;
        private string email;

        public UsuarioModelsController(FraganciaContext context)
        {
            _context = context;
            email = "";
            pass = "";
        }

        // GET: UsuarioModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Usuario.ToListAsync());
        }

        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UsuarioModel usuarios , string pass , string email)
        {
            usuarios.Contrasenna = pass;
            usuarios.Correo = email;

            var usuario = await _context.Usuario
            .SingleOrDefaultAsync(m => m.Correo == usuarios.Correo && m
            .Contrasenna == usuarios.Contrasenna);


            if (usuario == null)
            {
                ViewData["alert"] = "Credenciales incorrectos";
                return RedirectToAction("Login", "UsuarioModels");
                
            }
           

            ViewData["alert"] = "Credenciales correctos";
            Log.isSingin = true;
            Log.User = usuario;
            Log.isAdmin = usuario.Admin;
            return RedirectToAction("Index", "Productos"); 
  

        }

        // GET: UsuarioModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioModel = await _context.Usuario
                .FirstOrDefaultAsync(m => m.ID == id);
            if (usuarioModel == null)
            {
                return NotFound();
            }

            return View(usuarioModel);
        }

        // GET: UsuarioModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UsuarioModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nombre,Usuario,Correo,Contrasenna,Activo,Admin")] UsuarioModel usuarioModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuarioModel);
                await _context.SaveChangesAsync();
               
                return RedirectToAction(nameof(Login));
            }
            return View(usuarioModel);
        }

        // GET: UsuarioModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioModel = await _context.Usuario.FindAsync(id);
            if (usuarioModel == null)
            {
                return NotFound();
            }
            return View(usuarioModel);
        }

        // POST: UsuarioModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nombre,Usuario,Correo,Contrasenna,Activo,Admin")] UsuarioModel usuarioModel)
        {
            if (id != usuarioModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuarioModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioModelExists(usuarioModel.ID))
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
            return View(usuarioModel);
        }

        // GET: UsuarioModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioModel = await _context.Usuario
                .FirstOrDefaultAsync(m => m.ID == id);
            if (usuarioModel == null)
            {
                return NotFound();
            }

            return View(usuarioModel);
        }

        // POST: UsuarioModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuarioModel = await _context.Usuario.FindAsync(id);
            _context.Usuario.Remove(usuarioModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioModelExists(int id)
        {
            return _context.Usuario.Any(e => e.ID == id);
        }
    }
}
