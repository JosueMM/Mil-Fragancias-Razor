using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiFragancia.Models
{
    public class Imagen
    {
        [Key]
        public int ID { get; set; }
        public byte[] ImagenArray { get; set; }
        public char Activo { get; set; }
    }
}
