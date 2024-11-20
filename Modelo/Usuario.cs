using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        public int UsuarioId {  get; set; }
        public string NombreUsuario {  get; set; }
        public string Email {  get; set; }
        public string Clave { get; set; }
        public string Estado { get; set; } //Habilitado, inhabilitado;
        public string Nombre {  get; set; }
        public string Apellido { get; set; }
        public List<Grupo> Grupos { get; set; }

        public Usuario()
        {
            Grupos = new List<Grupo>();
        }

    }
}
