using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiFragancia.Models
{
    public class FraganciaContext : DbContext
    {
        public FraganciaContext(DbContextOptions<FraganciaContext> options)
          : base(options)
        {
        }

        public DbSet<Models.Carrito> Carrito { get; set; }

        public DbSet<Models.Imagen> Imagen { get; set; }
        public DbSet<Models.TipoProducto> TipoProducto { get; set; }
        public DbSet<MiFragancia.Models.Producto> Producto { get; set; }
        public DbSet<MiFragancia.Models.Usuario> UsuarioModel { get; set; }
    }
}
