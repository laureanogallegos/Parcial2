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
        Contexto contexto = new Contexto();

        public bool AgregarUsuario(Usuario nuevoUsuario)
        {
            var busqueda = contexto.Usuarios.FirstOrDefault(x => x.NombreUsuario == nuevoUsuario.NombreUsuario || x.Email == nuevoUsuario.Email);
            if (busqueda == null)
            {
                nuevoUsuario.Clave = Encrypt(nuevoUsuario.NombreUsuario, nuevoUsuario.Clave);
                contexto.Usuarios.Add(nuevoUsuario);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
        public bool EliminarUsuario(Usuario nuevoUsuario)
        {
            var busqueda = contexto.Usuarios.FirstOrDefault(x => x.NombreUsuario == nuevoUsuario.NombreUsuario);
            if (busqueda != null)
            {
                contexto.Usuarios.Remove(nuevoUsuario);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
        public bool ModificarUsuario(Usuario nuevoUsuario)
        {
            var busqueda = contexto.Usuarios.FirstOrDefault(x => x.NombreUsuario == nuevoUsuario.NombreUsuario);
            if (busqueda != null)
            {
                contexto.Usuarios.Update(nuevoUsuario);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public ReadOnlyCollection<Usuario> ListarUsuario()
        {
            return contexto.Usuarios.ToList().AsReadOnly();
        }
        public ReadOnlyCollection<Grupo> ListarGrupos()
        {
            return contexto.Grupos.ToList().AsReadOnly();
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
