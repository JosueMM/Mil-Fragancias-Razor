using System;
using ProyectMVC.Models;

namespace ProyectMVC.Models
{
    public class CarritoModel
    {
        

        public int Id { get; set; }
        public UsuarioModel Usuario { get; set; }
        public TipoProductoModel Producto { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }

        public CarritoModel(){

        }


    }
}