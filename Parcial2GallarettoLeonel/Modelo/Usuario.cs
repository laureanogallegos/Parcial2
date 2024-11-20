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
        public string Nombre { get; set; }

        public string Email { get; set; }

        public string Clave { get; set; }

        public bool Habilitado { get; set; }

        public List<Grupo> Grupos { get; set; }

        public Usuario()
        {
            Grupos = new List<Grupo>();
        }

        public bool AsignarGrupo(Grupo grupo)
        {
            var grupoExistente = Grupos.FirstOrDefault(i => i.Roll == grupo.Roll);
            if (grupoExistente == null)
            {

                Grupos.Add(grupo);
                return true;
            } return false;

        }
        public bool QuitarGrupo(Grupo grupo)
        {
            var grupoExistente = Grupos.FirstOrDefault(i => i.Roll == grupo.Roll);
            if (grupoExistente != null)
            {

                Grupos.Add(grupo);
                return true;
            }
            return false;

        }

    }
}
