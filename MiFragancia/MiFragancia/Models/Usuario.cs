using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiFragancia.Models
{
    public class Usuario
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Contrasenna { get; set; }
        public bool Activo { get; set; }
        public bool Admin { get; set; }


        public Usuario()
        {

        }
    }
}
