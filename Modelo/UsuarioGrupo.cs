using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
        public class UsuarioGrupo
        {
            public string NombreUsuario { get; set; }
            public Usuario Usuario { get; set; }

            public int GrupoId { get; set; }
            public Grupo Grupo { get; set; }
        }
}
