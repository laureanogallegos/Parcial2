using Microsoft.Identity.Client;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraUsuarios
    {
        Context _context;

       public ControladoraUsuarios()
        {
            _context = new Context();
        }

        public bool CrearUsuario(Usuario usuario)
        {
            try 
            {
                var buscarUsuario = _context.Usuarios.FirstOrDefault(u=>u.NombreUsuario == usuario.NombreUsuario && u.Correo == usuario.Correo);

                if (buscarUsuario == null)
                {
                    usuario.Clave = Encrypt(usuario.NombreUsuario, usuario.Clave);
                    _context.Add(usuario);
                    return _context.SaveChanges() > 0;
                }
                else return false;  
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EliminarUsuario(Usuario usuario)
        {
            try
            {
                var buscarUsuario = _context.Usuarios.FirstOrDefault(u => u.NombreUsuario == usuario.NombreUsuario && u.Correo == usuario.Correo);

                if (buscarUsuario != null)
                {
                    _context.Remove(usuario);
                    return _context.SaveChanges() > 0;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EditarUsuario(Usuario usuario)
        {
            try
            {
                var buscarUsuario = _context.Usuarios.FirstOrDefault(u => u.NombreUsuario == usuario.NombreUsuario && u.Correo == usuario.Correo);

                if (buscarUsuario != null)
                {
                    _context.Update(usuario);
                    return _context.SaveChanges() > 0;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
        public List<Usuario> RecuperarUsuarios()
        {
            return _context.Usuarios.ToList();
        }

        public string Encrypt (string usuario,string clave)
        {
            var saltBytes = Encoding.UTF8.GetBytes(usuario);
            var passwordBytes = Encoding.UTF8.GetBytes(clave);

            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 10000);
            var key = rfc2898DeriveBytes.GetBytes(32);

            return Convert.ToBase64String(key);
        }



    }
}
