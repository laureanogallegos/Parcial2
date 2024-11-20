using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string NombreDeUsuario { get; set; }
        public string Mail {  get; set; }
        public string clave { get; set; }  
        public string Estado { get; set; }
        public string Nombre {  get; set; }
        public string Apellido { get; set; }
        public List<Grupo> Grupos;

        public Usuario()
        {
            Grupos = new List<Grupo>();

        }
        public bool agregargrupo(Grupo grupo)
        {
            try
            {
                var GrupoExiste = Grupos.FirstOrDefault(d => d.Tipo == grupo.Tipo);
                if (GrupoExiste == null)
                {

                    Grupos.Add(grupo);





                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            

        }

    }
}
