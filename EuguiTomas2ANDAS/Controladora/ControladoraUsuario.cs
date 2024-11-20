using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraUsuario
    {
        Contexto contexto = new Contexto();

        //Obtener todos los usuarios
        public List<Usuario> ObtenerUsuarios()
        {
            return contexto.Usuarios.ToList();
        }
        //validar si existe el Nombre de Usuario y Email
        public bool ExisteUsuarioPorNombre(string nombreDeUsuario)
        {
            return contexto.Usuarios.Any(u => u.NombreDeUsuario == nombreDeUsuario);
        }
        public bool ExisteUsuarioPorEmail(string email) 
        {
            return contexto.Usuarios.Any(u => u.Email == email);
        }

        //Agregar Usuario
        public bool AgregarUsuario(Usuario nuevoUsuario)
        {
            if(ExisteUsuarioPorNombre(nuevoUsuario.NombreDeUsuario) || ExisteUsuarioPorEmail(nuevoUsuario.Email))
            {
                return false;
            }
            contexto.Usuarios.Add(nuevoUsuario);
            contexto.SaveChanges();
            return true;
        }

        //Eliminar Usuario
        public bool EliminarUsuario(Usuario eliminarUsuario) 
        {
            var busqueda = contexto.Usuarios.FirstOrDefault(u => u.NombreDeUsuario == eliminarUsuario.NombreDeUsuario);
            if(busqueda != null)
            {
                contexto.Usuarios.Remove(busqueda);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        //Modificar Usuario
        public bool ModificarUsuario(Usuario modificarUsuario)
        {
            var busqueda = contexto.Usuarios.FirstOrDefault(u => u.NombreDeUsuario == modificarUsuario.NombreDeUsuario);
            if(busqueda != null)
            {
                contexto.Usuarios.Update(modificarUsuario);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public string Encrypt(string usuario, string clave)
        {
            var saltBytes = Encoding.UTF8.GetBytes(usuario);
            var passwordBytes = Encoding.UTF8.GetBytes(clave);

            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 10000);
            var key = rfc2898DeriveBytes.GetBytes(32);

            return Convert.ToBase64String(key);
        }
    }
}
