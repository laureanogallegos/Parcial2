﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Grupo
    {
        public int Id {  get; set; }
        public string Rol {  get; set; }
        public string CodigoGrupo {  get; set; }

        public override string ToString()
        {
            return Rol;
        }
    }
}
