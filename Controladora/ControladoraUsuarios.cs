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
    public class ControladoraUsuarios
    {
        private static Lazy<ControladoraUsuarios> instance = new Lazy<ControladoraUsuarios>(() => new ControladoraUsuarios());
        public static ControladoraUsuarios Instance => instance.Value;
       
        private DbCreacion db;
        private ControladoraUsuarios() 
        {
            db = new DbCreacion();
        }

        public ReadOnlyCollection<Usuario> RecuperarUsuarios()
        {
            try
            {

                return db.Usuarios.Include(c => c.Grupos).ToList().AsReadOnly();
            }
            catch
            {
                return new ReadOnlyCollection<Usuario>(new List<Usuario>());
            }
        }

        public ReadOnlyCollection<Grupo> RecuperarGrupos()
        {
            try
            {
                return db.Grupos.ToList().AsReadOnly();
            }
            catch
            {
                return new ReadOnlyCollection<Grupo>(new List<Grupo>());
            }
        }

        public bool AgregarUsuario(Usuario usuario)
        {
            try
            {
                var existeUsuario = db.Usuarios.FirstOrDefault(c => c.NombreDeUsuario == usuario.NombreDeUsuario || c.Email == usuario.Email);
                if(existeUsuario == null)
                {
                    var claveEncryptada = Encrypt(usuario.NombreDeUsuario, usuario.Clave);
                    usuario.Clave = claveEncryptada;
                    db.Usuarios.Add(usuario);
                    return db.SaveChanges() > 0;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool ModificarUsuario(Usuario usuario)
        {
            try
            {
                var existeUsuario = db.Usuarios.FirstOrDefault(c => c.Id == usuario.Id);
                if (existeUsuario != null)
                {
                    var claveEncryptada = Encrypt(usuario.NombreDeUsuario, usuario.Clave);
                    usuario.Clave = claveEncryptada;
                    db.Usuarios.Update(usuario);
                    return db.SaveChanges() > 0;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarUsuario(Usuario usuario)
        {
            try
            {
                var existeUsuario = db.Usuarios.FirstOrDefault(c => c.Id == usuario.Id);
                if (existeUsuario != null)
                {
                    db.Usuarios.Remove(usuario);
                    return db.SaveChanges() > 0;
                }
                else
                {
                    return false;
                }
            }
            catch
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
