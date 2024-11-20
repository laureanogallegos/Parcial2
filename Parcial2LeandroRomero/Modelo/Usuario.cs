﻿namespace Modelo
{
    public class Usuario
    {


        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
        public string Estado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<Grupo> grupos = new List<Grupo> { };
    }
}