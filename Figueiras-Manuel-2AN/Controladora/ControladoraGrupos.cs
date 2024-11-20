using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraGrupos
    {
        Context _context;

       public ControladoraGrupos()
        {
            _context = new Context();
        }

        public bool AgregarGrupo(GrupoUsuario grupoUsuario) 
        {
            try
            {
                var buscarGrupo = _context.GrupoUsuarios.FirstOrDefault(g => g.Nombre == grupoUsuario.Nombre);

                if (buscarGrupo == null)
                {
                    _context.GrupoUsuarios.Add(grupoUsuario);
                    return _context.SaveChanges() > 0;
                }
                else return false;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool EliminarGrupo(GrupoUsuario grupoUsuario)
        {
            try
            {
                var buscarGrupo = _context.GrupoUsuarios.FirstOrDefault(g => g.Nombre == grupoUsuario.Nombre);

                if (buscarGrupo != null)
                {
                    _context.GrupoUsuarios.Remove(grupoUsuario);
                    return _context.SaveChanges() > 0;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EditarGrupo(GrupoUsuario grupoUsuario)
        {
            try
            {
                var buscarGrupo = _context.GrupoUsuarios.FirstOrDefault(g => g.Nombre == grupoUsuario.Nombre);

                if (buscarGrupo != null)
                {
                    _context.GrupoUsuarios.Update(grupoUsuario);
                    return _context.SaveChanges() > 0;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<GrupoUsuario> RecuperarGrupos()
        {
            return _context.GrupoUsuarios.ToList();
        }
    }
}
