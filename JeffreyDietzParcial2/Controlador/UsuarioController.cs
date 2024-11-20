using JeffreyDietzParcial2.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JeffreyDietzParcial2.Modelo;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;

namespace JeffreyDietzParcial2.Controlador
{
    public class UsuarioController
    {
        private readonly Context _context;

        public UsuarioController()
        {
            _context = new Context();
        }

        // Método para recuperar todos los usuarios con su/s grupo/s
        public List<Usuario> RecuperarUsuarios()
        {
            return _context.Usuarios.Include(u => u.Grupos).ToList();
        }

        // Método para agregar un nuevo Usuario
        public bool AgregarUsuario(Usuario usuario)
        {
            try
            {
                var usuarioExistente = _context.Usuarios.FirstOrDefault(u => u.Username == usuario.Username);
                if (usuarioExistente == null && usuarioExistente?.Clave != "")
                {
                    usuario.Clave = Encrypt(usuario.Username, usuario.Clave);
                    _context.Usuarios.Add(usuario);
                    return _context.SaveChanges() > 0;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Método para modificar un usuario existente
        public bool ModificarUsuario(Usuario usuario)
        {
            try
            {
                var usuarioExistente = _context.Usuarios.FirstOrDefault(u => u.Username == usuario.Username);
                if (usuarioExistente != null)
                {
                    _context.Usuarios.Update(usuario);
                    return _context.SaveChanges() > 0;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Método para eliminar un usuario
        public bool EliminarUsuario(Usuario usuario)
        {
            try
            {
                var usuarioExistente = _context.Usuarios.FirstOrDefault(u => u.Username == usuario.Username);
                if (usuarioExistente != null)
                {
                    _context.Usuarios.Remove(usuario);
                    return _context.SaveChanges() > 0;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private string Encrypt(string usuario, string clave) 
        {
            var saltBytes = Encoding.UTF8.GetBytes(usuario);
            var passwordBytes = Encoding.UTF8.GetBytes(clave);

            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 10000);
            var key = rfc2898DeriveBytes.GetBytes(32);

            return Convert.ToBase64String(key);
        }
    }
}
