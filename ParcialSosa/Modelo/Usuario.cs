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
        public string NombreUsuario { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
        public string Estado { get; set; }
        public string Nombre {  get; set; }
        public string Apellido { get; set; }

        public List<Grupo> Grupos { get; set; }

        public Usuario()
        { 
            Grupos = new List<Grupo>();
        }

        public bool AgregarGrupo(Grupo grupo)
        {
            var existeGrupo = Grupos.FirstOrDefault(x => x.Tipo == grupo.Tipo);
            if (existeGrupo == null)
            {
                Grupos.Add(grupo);
                return true;
            }
            else return false;
        }

        public bool ModificarGrupo(List<Grupo> grupos)
        {
            Grupos.Clear();

            foreach (var grupo in grupos)
            {
                Grupos.Add(grupo);
            }

            return true;
        }

        public string NombreGrupos // Para poder ver los grupos en la grilla
        {
            get => string.Join(", ", Grupos.Select(f => f.Tipo));
        }

    }
}
