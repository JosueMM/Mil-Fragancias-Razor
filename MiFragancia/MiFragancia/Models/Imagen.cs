using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiFragancia.Models
{
    public class Imagens
    {
        [Key]
        public int ID { get; set; }
        public byte[] Imagen { get; set; }
        public bool Activo { get; set; }
    }
}
