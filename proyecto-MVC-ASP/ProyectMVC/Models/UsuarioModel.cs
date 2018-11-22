using System;
using ProyectMVC.Models;

namespace ProyectMVC.Models
{
    public class UsuarioModel
    {
       
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Contrasenna { get; set; }
        public bool Activo { get; set; }
        public bool Admin { get; set; }
    

        public UsuarioModel(){

        }


    }
}