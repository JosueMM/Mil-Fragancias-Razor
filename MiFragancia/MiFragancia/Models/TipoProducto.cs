using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MiFragancia.Models
{
    public class TipoProducto
    {
        [Key]
        public int ID { get; set; }
        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId ")]
        public virtual Usuario Usuario { get; set; }
        public int ProductoId { get; set; }
        [ForeignKey("ProductoId ")]
        public virtual Producto Producto { get; set; }
        
        public int Cantidad { get; set; }
        public float Precio { get; set; }

        public TipoProducto()
        {

        }
    }
}
