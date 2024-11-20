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
        public List<Grupo> GruposDelUsuario { get; set; }
        public Usuario()
        {
            GruposDelUsuario = new List<Grupo>();
        }
        public void AgregarRoll(Grupo roll)
        {
            var busqueda = GruposDelUsuario.FirstOrDefault(gru=>gru.NombreDelGrupo==roll.NombreDelGrupo);
            if (busqueda==null)
            {
                GruposDelUsuario.Add(roll);
            }
        }
        public override string ToString()
        {
            return NombreDeUsuario;
        }
    }
}
