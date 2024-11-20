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
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario {  get; set; }
        public string Clave {  get; set; }
        public string Correo {  get; set; }
        public bool Estado {  get; set; }

        public List<GrupoUsuario> Grupos { get; set; }


        public bool AgregarGrupo(GrupoUsuario grupoUsuario)
        {
            var buscarGrupo = Grupos.FirstOrDefault(g=>g.Nombre==grupoUsuario.Nombre);

            if(buscarGrupo == null)
            {
                Grupos.Add(grupoUsuario);
                return true;
            }
            else return false;
        }

        public bool EliminarGrupo(GrupoUsuario grupoUsuario)
        {

            var buscarGrupo = Grupos.FirstOrDefault(g => g.Nombre == grupoUsuario.Nombre);

            if (buscarGrupo != null)
            {
                Grupos.Remove(grupoUsuario);
                return true;
            }
            else return false;
        }
    }
}
