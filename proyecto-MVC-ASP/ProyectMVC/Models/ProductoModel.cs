using System;
using ProyectMVC.Models;

namespace ProyectMVC.Models
{
    public class ProductoModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public char Activo { get; set; }
        public virtual TipoProductoModel Tipo  { get; set; }
        public int TipoProductoId {get; set;}
        public virtual ImagenModel Imagen { get; set; }
        public int ImagenId {get; set;}
        public ProductoModel(){

        }


    }
}