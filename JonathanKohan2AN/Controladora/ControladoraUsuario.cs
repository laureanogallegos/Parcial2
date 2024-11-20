using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraUsuario
    {
        public RegisterContexto _context;
        public ControladoraUsuario()
        {
            _context = new RegisterContexto();
        }
        public bool Agregar(Usuario usuario)
        {
            if (_context.usuarios.FirstOrDefault(x => x.NombreDeUsuario == usuario.NombreDeUsuario) == null && _context.usuarios.FirstOrDefault(x => x.Email == usuario.Email) == null)
            {
                _context.usuarios.Add(usuario);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Eliminar(Usuario usuario)
        {
            if (_context.usuarios.FirstOrDefault(x => x.NombreDeUsuario == usuario.NombreDeUsuario) != null)
            {
                _context.usuarios.Remove(usuario);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public void Modificar(Usuario usuario)
        {
            _context.usuarios.Remove(_context.usuarios.FirstOrDefault(x => x.Id == usuario.Id));
            _context.usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public ReadOnlyCollection<Usuario> ListarUsuarios()
        {
            return _context.usuarios.ToList().AsReadOnly();
        }
        public ReadOnlyCollection<Grupo> ListarGrupos()
        {
            return _context.grupos.ToList().AsReadOnly();
        }
    }
}
