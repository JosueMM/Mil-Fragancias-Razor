using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MiFragancia.Models
{
    public class Producto
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public bool Activo { get; set; }
        public int TipoProductoId { get; set; }
        [ForeignKey("TipoProductoId ")]

        public virtual TipoProducto Tipo { get; set; }
        public int ImagenId { get; set; }
        [ForeignKey("ImagenId ")]
        public virtual Imagen Imagen { get; set; }
       
        public Producto()
        {

        }

    }
}
