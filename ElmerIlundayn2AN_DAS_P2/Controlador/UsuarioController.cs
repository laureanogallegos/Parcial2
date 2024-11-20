using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class UsuarioController
    {
        UsuarioContext _context = new UsuarioContext();
        public bool AgregarUsuario(Usuario nuevoUsuario)
        {
            try
            {
                var usuarioExistente = _context.Usuarios.FirstOrDefault(u => u.NombreUsuario == nuevoUsuario.NombreUsuario);
                var emailExistente = _context.Usuarios.FirstOrDefault(u => u.Email == nuevoUsuario.Email);
                if (usuarioExistente == null && emailExistente == null)
                {
                    nuevoUsuario.Clave = Encrypt(nuevoUsuario.NombreUsuario, nuevoUsuario.Clave);
                    _context.Usuarios.Add(nuevoUsuario);

                    _context.SaveChanges();
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
        }

        public bool EliminarUsuario (Usuario usuarioARemover)
        {
            try
            {
                var usuarioExistente = _context.Usuarios.FirstOrDefault(u => u.NombreUsuario == usuarioARemover.NombreUsuario);
                if (usuarioExistente != null)
                {
                    _context.Usuarios.Remove(usuarioARemover);

                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
        }
        public bool ModificarUsuario (Usuario usuarioAModificar)
        {
            try
            {
                var usuarioExistente = _context.Usuarios.FirstOrDefault(u => u.NombreUsuario == usuarioAModificar.NombreUsuario);
                if (usuarioExistente != null)
                {
                    _context.Usuarios.Update(usuarioAModificar = usuarioExistente);

                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
        }

        public IReadOnlyCollection<Usuario> ListarUsuarios()
        {
            try
            {
                return _context.Usuarios.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public IReadOnlyCollection<Grupo> ListarGrupos()
        {
            try
            {
                return _context.Grupos.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private string Encrypt (string usuario, string clave)
        {
            var saltBytes = Encoding.UTF8.GetBytes(usuario);
            var passwordBytes = Encoding.UTF8.GetBytes(clave);

            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 10000);
            var key = rfc2898DeriveBytes.GetBytes(32);

            return Convert.ToBase64String(key);
        }
    }
}
