﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiFragancia.Models
{
    public static class Log
    {
        public static bool isSingin { get; set; }
        public static bool isAdmin { get; set; }
        public static UsuarioModel User { get; set; }
        public static IList<Producto> carrito { get; set; }
        public static double cantidadProd { get; set; }
        public static string Messajes { get; set; }
        public static IList<Producto> Factura { get; set; }
        public static double total { get; set; }
        public static string imagen { get; set; }
        public static IFormFile path { get; set; }
    }
}
