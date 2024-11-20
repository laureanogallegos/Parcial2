using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        public string NombreGrupos
        {
            get => string.Join(", ", Grupos.Select(f => f.Nombre));
        }



        public bool Agregar(Grupo grupo)
        {
            try
            {
                var existe = Grupos.FirstOrDefault(f => f.Nombre == grupo.Nombre);
                if (existe == null)
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

        public bool Modificar(List<Grupo> grupos)
        {
            Grupos.Clear();

            foreach (var grupo in grupos)
            {
                Grupos.Add(grupo);
            }

            return true;
        }


    }
}
