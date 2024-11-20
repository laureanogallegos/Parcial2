using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraGrupos
    {
        private ContextoUsuarios _context = new ContextoUsuarios();

        public void RegistrarGrupo(Grupo grupo)
        {
            var busqueda = _context.Grupos.FirstOrDefault(gru => gru.NombreDelGrupo == grupo.NombreDelGrupo);
            if (busqueda == null)
            {
                _context.Grupos.Add(grupo);
                _context.SaveChanges();
            }
        }
        public void EliminarUsuario(Grupo grupo)
        {
            _context.Grupos.Remove(grupo);
            _context.SaveChanges();
        }
        public void ModificarUsuario(Grupo grupo)
        {
            var buscar = _context.Grupos.FirstOrDefault(gru => gru.NombreDelGrupo == grupo.NombreDelGrupo);
            if (buscar != null)
            {
                grupo.Id = buscar.Id;
                _context.Remove(buscar);
                _context.Add(grupo);
                _context.SaveChanges();
            }
        }
        public ReadOnlyCollection<Grupo> LeerGrupos()
        {
            return _context.Grupos.ToList().AsReadOnly();
        }
    }
}
