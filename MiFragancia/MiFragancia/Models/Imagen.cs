using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiFragancia.Models
{
    public class Imagens
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string ImagePath { get; set; }
        public bool Activo { get; set; }
       [NotMappedAttribute]
        public IFormFile imageFile { get; set; }
    }
}
