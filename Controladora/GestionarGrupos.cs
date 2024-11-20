using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace Controladora
{
    public class GestionarGrupos
    {
        private UsuariosContext contexto { get; set; }
        public GestionarGrupos(UsuariosContext contexto)
        {
            this.contexto = contexto;
        }

        public bool AgregarUsuario(Grupo grupo)
        {

            try
            {
                var grupoExistente = contexto.Grupos.FirstOrDefault(m => m.NombreGrupo == grupo.NombreGrupo);
                if (grupoExistente == null)
                {
                    contexto.Grupos.Add(grupo);
                    return contexto.SaveChanges() > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;

        }

        public ReadOnlyCollection<Grupo> ListarGrupos()
        {
            return contexto.Grupos.ToList().AsReadOnly();
        }
    }
}
