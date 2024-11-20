using Modelo;
using System.Security.Cryptography;
using System.Text;

namespace Controladora
{
    public class ControladoraUsuarios
    {
        private Context contexto;

        public ControladoraUsuarios()
        {
            contexto = new Context();
        }

        public bool AgregarUsuario(Usuario usuario)
        {
            try
            {
                var usuarioExistente = contexto.Usuarios.FirstOrDefault(u => u.NombreUsuario == usuario.NombreUsuario || u.Email == usuario.Email);
                if (usuarioExistente == null)
                {
                    usuario.Clave = Encrypt(usuario.NombreUsuario, usuario.Clave);
                    contexto.Usuarios.Add(usuario);
                    return contexto.SaveChanges() > 0;
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
            return contexto.Usuarios.ToList();
        }

        public bool ModificarUsuario(Usuario usuario)
        {
            try
            {
                var usuarioExistente = contexto.Usuarios.FirstOrDefault(u => u.NombreUsuario == usuario.NombreUsuario);
                if (usuarioExistente == null)
                {
                    contexto.Usuarios.Update(usuario);
                    return contexto.SaveChanges() > 0;
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
                var usuarioExistente = contexto.Usuarios.FirstOrDefault(u => u.NombreUsuario == usuario.NombreUsuario);
                if (usuarioExistente != null)
                {
                    contexto.Usuarios.Remove(usuario);
                    return contexto.SaveChanges() > 0;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
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
