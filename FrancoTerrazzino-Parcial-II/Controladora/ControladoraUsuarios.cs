using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraUsuarios
    {
        private ContextoUsuarios _context = new ContextoUsuarios();

        public void RegistrarUsuario(Usuario usuario)
        {
            var busqueda = _context.Usuarios.FirstOrDefault(u => u.NombreDeUsuario==usuario.NombreDeUsuario);
            if (busqueda==null)
            {
                usuario.Clave = Encrypt(usuario.NombreDeUsuario,usuario.Clave);
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
            }
        }
        public void EliminarUsuario(Usuario usuario)
        {
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
        }
        public void ModificarUsuario(Usuario usuario)
        {
            var buscar = _context.Usuarios.FirstOrDefault(u => u.NombreDeUsuario == usuario.NombreDeUsuario);
            if (buscar!=null)
            {
                usuario.Id = buscar.Id;
                _context.Remove(buscar);
                _context.Add(usuario);
                _context.SaveChanges();
            }    
        }

        public ReadOnlyCollection<Usuario> LeerUsuarios()
        {
            return _context.Usuarios.ToList().AsReadOnly();
        }
        public ReadOnlyCollection<Grupo> LeerGrupos()
        {
            return _context.Grupos.ToList().AsReadOnly();   
        }
        private string Encrypt(string usuario, string clave)
        {
            var saltBytes = Encoding.UTF8.GetBytes(usuario);
            var passwordBytes = Encoding.UTF8.GetBytes(clave);

            var rfc2898Derivebytes = new Rfc2898DeriveBytes(passwordBytes, saltBytes,10000);
            var key = rfc2898Derivebytes.GetBytes(32);

            return Convert.ToBase64String(key);
        }
    }

}
