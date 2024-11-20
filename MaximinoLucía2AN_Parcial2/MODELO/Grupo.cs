using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Grupo
    {
        public int Id {  get; set; }
        public string TipoGrupo { get; set; }
        public int CodigoGrupo { get; set; }
        public override string ToString()
        {
            return $"{TipoGrupo}";
        }
    }
}
