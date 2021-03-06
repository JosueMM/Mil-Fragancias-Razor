﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiFragancia.Models;

namespace MiFragancia.Controllers
{
    public class HomeController : Controller
    {
        private readonly FraganciaContext _context;
 


        public IActionResult Index()
        {
            ViewData["alert"] = "Introduzca sus credenciales";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Compra las fragancias que mas te gusten a buen precio!";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
