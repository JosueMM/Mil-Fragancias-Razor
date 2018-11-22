using System;
using ProyectMVC.Models;

namespace ProyectMVC.Models
{
    public class ImagenModel
    {
      public int Id { get; set; }
        public byte[] ImagenArray { get; set; }
        public char Activo { get; set; }
       
    }
}