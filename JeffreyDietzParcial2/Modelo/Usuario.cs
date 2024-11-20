using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JeffreyDietzParcial2.Modelo
{
    public class Usuario
    {
        public string Username { get; set; }
        public string Clave { get; set; }
        public string Email { get; set; }
        public bool EstaHabilitado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<Grupo> Grupos { get; set; }

        public Usuario() 
        {
            Grupos = new List<Grupo>();
        }

        public bool AñadirGrupo(Grupo grupo)
        {
            var existeGrupo = Grupos.FirstOrDefault(x => x.CodigoGrupo == grupo.CodigoGrupo);
            if (existeGrupo != null)
            {
                Grupos.Add(grupo);
                return true;
            }
            return false;
                
        }
    }
}
