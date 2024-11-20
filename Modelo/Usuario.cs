using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreDeUsuario {  get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
        public bool Estado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public List<Grupo> Grupos { get; set; } = new List<Grupo>();

        public bool AgregarGrupo(Grupo grupo)
        {
            var existeGrupo = Grupos.FirstOrDefault( c => c.Rol == grupo.Rol );
            if (existeGrupo == null)
            { 
                Grupos.Add( grupo );
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EliminarGrupo(Grupo grupo) 
        {
            var existeGrupo = Grupos.FirstOrDefault(c => c.Rol == grupo.Rol);
            if (existeGrupo != null)
            {
                Grupos.Remove(grupo);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
