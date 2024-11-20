using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
        public class Usuario
        {
            public string NombreUsuario { get; set; }
            public string Email { get; set; }
            public string Clave { get; set; }
            public string Estado { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }

            public ICollection<UsuarioGrupo> UsuarioGrupos { get; set; } = new List<UsuarioGrupo>();
        }

    
}
