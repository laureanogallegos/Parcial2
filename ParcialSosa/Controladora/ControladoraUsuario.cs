using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraUsuario
    {
        private Contexto contexto;

        public ControladoraUsuario()
        {
            contexto = new Contexto();
        }

        public bool Agregar(Usuario usuario)
        {
            try
            {
                var existeUsuarioNombre = contexto.Usuarios.FirstOrDefault(x => x.NombreUsuario == usuario.NombreUsuario);
                var existeUsuarioEmail = contexto.Usuarios.FirstOrDefault(x => x.Email == usuario.Email);

                if(existeUsuarioEmail == null && existeUsuarioNombre == null)
                {
                    contexto.Usuarios.Add(usuario);
                    return contexto.SaveChanges() > 0;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Modificar(Usuario usuario)
        {
            try
            {
                var existeUsuarioNombre = contexto.Usuarios.FirstOrDefault(x => x.NombreUsuario == usuario.NombreUsuario);
                var existeUsuarioEmail = contexto.Usuarios.FirstOrDefault(x => x.Email == usuario.Email);

                if (existeUsuarioEmail != null && existeUsuarioNombre != null)
                {
                    contexto.Usuarios.Update(usuario);
                    return contexto.SaveChanges() > 0;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Eliminar(Usuario usuario)
        {
            try
            {
                var existeUsuarioNombre = contexto.Usuarios.FirstOrDefault(x => x.NombreUsuario == usuario.NombreUsuario);

                if (existeUsuarioNombre != null)
                {
                    contexto.Usuarios.Remove(usuario);
                    return contexto.SaveChanges() > 0;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Usuario> Usuarios()
        {
            return contexto.Usuarios.Include(x=>x.Grupos).ToList();
        }

        public List<Grupo> Grupos()
        {
            return contexto.Grupos.ToList();
        }

       public string Encrypt(string usuario, string clave)
        {
            var saltBytes = Encoding.UTF8.GetBytes(usuario);
            var passwordBytes = Encoding.UTF8.GetBytes(clave);

            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes,saltBytes,10000);
            var key = rfc2898DeriveBytes.GetBytes(32);

            return Convert.ToBase64String(key);
        }
    }
}
