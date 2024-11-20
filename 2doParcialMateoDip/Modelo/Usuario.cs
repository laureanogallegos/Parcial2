using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        public int Id {  get; set; }
        public string NombreUsuario {  get; set; }
        public string Email {  get; set; }
        public string Clave {  get; set; }
        public bool Estado {  get; set; }
        public string Nombre {  get; set; }
        public string Apellido {  get; set; }

        public List<Grupo> Grupos;

        public Usuario()
        {
            Grupos = new List<Grupo>();
        }

        public bool AgregarGrupo(Grupo nuevoGrupo)
        {
            var busqueda = Grupos.FirstOrDefault(x=>x.CodigoGrupo == nuevoGrupo.CodigoGrupo);
            if (busqueda == null)
            {
                Grupos.Add(nuevoGrupo);
                return true;
            }
            return false;
        }

        public ReadOnlyCollection<Grupo> ListarGrupos()
        {
            return Grupos.AsReadOnly();
        }
    }
}
