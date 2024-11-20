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
    public class ControladoraUsuario
    {
        private Context context;

        public ControladoraUsuario()
        {
            context = new Context();
        }

        public List<Grupo> RecuperarGrupos()
        {
            return context.Grupos.ToList();
        }

        public List<Usuario> RecuperarUsuarios()
        {
            return context.Usuarios.Include(p => p.Grupos).ToList();
        }
        private string Encrypt(string usuario, string clave)
        {
            var saltBytes = Encoding.UTF8.GetBytes(usuario);
            var passwordBytes = Encoding.UTF8.GetBytes(clave);

            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 10000);
            var key = rfc2898DeriveBytes.GetBytes(32);

            return Convert.ToBase64String(key);
        }
        public bool Agregar(Usuario usuario)
        {
            try
            {
                var existe = context.Usuarios.FirstOrDefault(x => x.NombreUsuario == usuario.NombreUsuario || x.Email == usuario.Email);
                if (existe == null)
                {
                    
                    usuario.Clave = Encrypt(usuario.NombreUsuario, usuario.Clave);

                    
                    context.Usuarios.Add(usuario);
                    return context.SaveChanges() > 0;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                
                return false;
            }
        }

        public bool Modificar(Usuario usuario)
        {
            try
            {
                var existe = context.Usuarios.FirstOrDefault(x => x.NombreUsuario == usuario.NombreUsuario);
                if (existe != null)
                {
                    context.Usuarios.Update(usuario);
                    return context.SaveChanges() > 0;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool Eliminar(Usuario usuario)
        {
            try
            {
                var existe = context.Usuarios.FirstOrDefault(x => x.NombreUsuario == usuario.NombreUsuario);
                if (existe != null)
                {
                    context.Usuarios.Remove(usuario);
                    return context.SaveChanges() > 0;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }

        }


    }
}
