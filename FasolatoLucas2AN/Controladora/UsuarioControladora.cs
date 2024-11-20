using Microsoft.EntityFrameworkCore;
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
    public class UsuarioControladora
    {
        Contexto _context;
        public UsuarioControladora()
        {
            _context = new Contexto();
        }

        public bool CrearUsuario(Usuario usuario)
        {
            try
            {
                var usuarioExistente = _context.Usuarios.FirstOrDefault(u => u.NombreUsuario == usuario.NombreUsuario || u.Email == usuario.Email);
                if (usuarioExistente == null)
                {
                    usuario.Clave = Encrypt(usuario.NombreUsuario, usuario.Clave);
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

        public bool ModificarUsuario(Usuario usuario)
        {
            try
            {
                var usuarioExistente = _context.Usuarios.FirstOrDefault(u => u.NombreUsuario == usuario.NombreUsuario || u.Email == usuario.Email);
                if (usuarioExistente == null)
                {
                    usuario.Clave = Encrypt(usuario.NombreUsuario, usuario.Clave);
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

        public bool EliminarUsuario(Usuario usuario)
        {
            try
            {
                var usuarioExistente = _context.Usuarios.FirstOrDefault(u => u.NombreUsuario == usuario.NombreUsuario || u.Email == usuario.Email);
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
        public List<Usuario> RecuperarUsuarios()
        {
            return (List<Usuario>)_context.Usuarios.Include(x => x.Grupos);
        }
        //public List<Grupo> RecuperarGrupos()
        //{
        //    return (List<Grupo>)_context.Grupos.Include(x => x.Usuarios);
        //}

        public List<Grupo> RecuperarGrupos()
        {
            return _context.Grupos.ToList();
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
