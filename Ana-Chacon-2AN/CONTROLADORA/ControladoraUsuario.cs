using MODELO;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;
namespace CONTROLADORA
{
    public class ControladoraUsuario
    {
        public Context context;
        private static readonly Lazy<ControladoraUsuario> instancia = new (() => new ControladoraUsuario());
        private static ControladoraUsuario Instancia = instancia.Value;
        public ControladoraUsuario() 
        {
            context = new Context();
        }
        public List<Usuarios> RecuperarUsuario()
        {
            try
            {
                return context.Usuarios.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public string AgregrarUsuario(Usuarios usuarios)
        {
            try
            {
                var listarUsuario = context.Usuarios.ToList();
                var usuarioEncontrado = listarUsuario.FirstOrDefault(x => x.NombreUsuario == usuarios.NombreUsuario && x.Email == usuarios.Email);
                if (usuarioEncontrado == null)
                {
                    context.Add(usuarios);
                    context.SaveChanges();
                    return "el usuario se agrego";
                }
                else return "el usuario no existe";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string QuitarUsuario (Usuarios usuarios)
        {
            try
            {
                var listarUsuario = context.Usuarios.ToList();
                var usuarioEncontrado = listarUsuario.FirstOrDefault(x=>x.NombreUsuario == usuarios.NombreUsuario && x.Email == usuarios.Email);
                if (usuarioEncontrado != null)
                {
                    context.Remove(usuarios);
                    context.SaveChanges();
                    return "Se elimino el usuario";
                }
                else return "El usuario no existe";
            }
            catch
            {
                return "Error desconocido";
            }
        }
        public string ModificarUsuario(Usuarios usuarios)
        {
            try
            {
                var listarUsuario = context.Usuarios.ToList();
                var usuarioEncontrado = listarUsuario.FirstOrDefault(x => x.NombreUsuario == usuarios.NombreUsuario && x.Email == usuarios.Email);
                if (usuarioEncontrado != null)
                {
                    context.Update(usuarios);
                    context.SaveChanges();
                    return "El usuario se modifico";
                }
                else return "El usuario no existe";
            }
            catch (Exception ex)
            {
                return "Error desconocido" +ex.Message +ex.InnerException.Message;
            }
        }

        private string Encrypt(string usuario, string clave)
        {
            var saltBytes = Encoding.UTF8.GetBytes(usuario);
            var passwordBytes = Encoding.UTF8.GetBytes(clave);
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, saltBytes,10000);
            var key = rfc2898DeriveBytes.GetBytes(32);
            return Convert.ToBase64String(key);
        }



    }
}
