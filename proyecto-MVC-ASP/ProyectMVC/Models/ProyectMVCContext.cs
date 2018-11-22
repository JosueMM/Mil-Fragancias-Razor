using Microsoft.EntityFrameworkCore;
using ProyectMVC.Models;


namespace ProyectMVC.Models
{
    public class ProyectMVCContext : DbContext
    {
         public ProyectMVCContext (DbContextOptions<ProyectMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Models.CarritoModel> Carrito { get; set; }
       
        public DbSet<Models.ImagenModel> Imagen { get; set; }
        public DbSet<Models.TipoProductoModel> TipoProducto { get; set; }
        public DbSet<ProyectMVC.Models.ProductoModel> Producto { get; set; }
        public DbSet<ProyectMVC.Models.UsuarioModel> UsuarioModel { get; set; }
    }
}
