using Microsoft.EntityFrameworkCore;
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
        Contexto _context;
        public ControladoraUsuarios()
        {
            _context = new Contexto();
        }

        public List<Usuario> Listar()
        {
            return _context.Usuarios.ToList();
        }
        public List<Grupo> Grupos() 
        {   
            return _context.Grupos.ToList();
        }

        public string Agregar(Usuario usuario) 
        { 
            var usuarioExisrente = _context.Usuarios.FirstOrDefault(u => u.Nombre == usuario.Nombre  || u.Email== usuario.Email);

            if (usuarioExisrente == null)
            {
                usuario.Clave = Encrypt(usuario.Nombre,usuario.Clave);
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
                return "Usuario Agregado";
            }
            else return "Usuario o Email Duplicado";

        
        }

        public string Modificar(Usuario usuario)
        {
            var usuarioExisrente = _context.Usuarios.FirstOrDefault(u => u.Nombre == usuario.Nombre || u.Email == usuario.Email);

            if (usuarioExisrente == null)
            {
                _context.Usuarios.Update(usuario);
                _context.SaveChanges();
                return "Usuario Modificado";
            }
            else return "Usuario o Email Duplicado";


        }

        public string Eliminar(Usuario usuario)
        {
            var usuarioExisrente = _context.Usuarios.FirstOrDefault(u => u.Nombre == usuario.Nombre || u.Email == usuario.Email);

            if (usuarioExisrente != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
                return "Usuario Eliminado";
            }
            else return "No se puedo eliminar el usuario";


        }

        private string Encrypt(string usuario, string clave)
        {
            var salBytes = Encoding.UTF8.GetBytes(usuario);
            var passwordBytes = Encoding.UTF8.GetBytes(clave);

            var rfc2838DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salBytes, 10000);
            var key = rfc2838DeriveBytes.GetBytes(32);

            return Convert.ToBase64String(key);
        }

    }
}
