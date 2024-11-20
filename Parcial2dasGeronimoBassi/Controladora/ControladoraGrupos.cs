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

        public List<Grupo> listargrupos()
        {
            return _context.Grupos.ToList();
        }

        public bool AgregarGrupo(Grupo grupo)
        {
            try
            {
                var Grupoexiste = _context.Grupos.FirstOrDefault(p => p.Tipo == grupo.Tipo);
                
                if (Grupoexiste == null)
                {
                    _context.Add(grupo);
                    return _context.SaveChanges() > 0;

                }
                else return false;


            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool ModificarGrupo(Grupo grupo)
        {
            try
            {
                var Grupoexiste = _context.Grupos.FirstOrDefault(p => p.Tipo == grupo.Tipo);

                if (Grupoexiste != null)
                {
                    _context.Update(grupo);
                    return _context.SaveChanges() > 0;

                }
                else return false;


            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool EliminarGrupo(Grupo grupo)
        {
            try
            {
                var Grupoexiste = _context.Grupos.FirstOrDefault(p => p.Tipo == grupo.Tipo);

                if (Grupoexiste != null)
                {
                    _context.Update(grupo);
                    return _context.SaveChanges() > 0;

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
