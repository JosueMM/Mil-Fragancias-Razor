using System;
using ProyectMVC.Models;

namespace ProyectMVC.Models
{
    public class TipoProductoModel
    {public int Id { get; set; }
        public virtual UsuarioModel Usuario { get; set; }
        public int UsuarioId {get; set;}
        public virtual ProductoModel Producto { get; set; }
        public int ProductoId {get; set;}
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public TipoProductoModel(){

        }


    }
}