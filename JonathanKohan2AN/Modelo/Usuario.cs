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
        public string NombreDeUsuario { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
        public bool Estado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<Grupo> grupos;

        Usuario()
        {
            grupos= new List<Grupo>();
        }

        public bool AgregarGrupo(Grupo grupo) 
        {
            if(grupos.FirstOrDefault(x=>x.Id == grupo.Id) == null) 
            {
                grupos.Add(grupo);
                return true;
            }
            return false;
        }
        public bool EliminarGrupo(Grupo grupo)
        {
            if (grupos.FirstOrDefault(x => x.Id == grupo.Id) != null)
            {
                grupos.Remove(grupo);
                return true;
            }
            return false;
        }
    }
}
