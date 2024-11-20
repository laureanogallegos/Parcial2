using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Modelo;
using System.Security.Cryptography;
using System.Text;

namespace Controladora
{
    public class ControladoraUsuarios
    {
        Context context = new Context();

        public bool AgregarUsuario(Usuario nuevoUsuario)
        {
            var buscarUsuario = context.Usuarios.FirstOrDefault(u => u.Nombre == nuevoUsuario.NombreUsuario);
            if (buscarUsuario == null)
            {
                context.Usuarios.Add(nuevoUsuario);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool ModificarUsuario(Usuario usuario)
        {
            var buscarUsuarioModificar = context.Usuarios.FirstOrDefault(m => m.Nombre == usuario.NombreUsuario);
            if (buscarUsuarioModificar == null)
            {
                context.Usuarios.Update(usuario);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool EliminarUsuario(Usuario usuarioAEliminar)
        {
            var buscarUsuarioEliminar = context.Usuarios.FirstOrDefault(m => m.Nombre == usuarioAEliminar.NombreUsuario);
            if (buscarUsuarioEliminar == null)
            {
                context.Usuarios.Update(usuarioAEliminar);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public List<Usuario> ListarUsuario()
        {
            return context.Usuarios.ToList();
        }
        


    }
}
