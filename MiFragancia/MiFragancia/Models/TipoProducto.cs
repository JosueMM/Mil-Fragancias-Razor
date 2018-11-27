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
        public string Tipo { get; set; }
        public bool Activo { get; set; }

        public TipoProducto()
        {

        }
    }
}
