using MODELO;
using System.Security.Cryptography;
using System.Text;

namespace CONTROLADORA
{
    public class ControladoraUsuarios
    {
        private UsuarioContext context;
        private ControladoraUsuarios()
        {
            context = new UsuarioContext();
        }
        private static ControladoraUsuarios instancia;
        public static ControladoraUsuarios Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraUsuarios();
                }
                return instancia;
            }
        }
        public List<Usuario> RecuperarUsuarios()
        {
            try
            {
                {
                    return context.Usuarios.ToList();
                }
            }catch
            {
                throw;
            }
        }
        public List<Grupo> RecuperarGrupos()
        {
            try
            {
                {
                    return context.Grupos.ToList();
                }
            }
            catch
            {
                throw;
            }
        }
        public string AgregarUsuario(Usuario usuario)
        {
            try
            {
                var listarUsuarios = context.Usuarios.ToList();
                var usuarioEncontrado = listarUsuarios.FirstOrDefault(x => x.NombreUsuario == usuario.NombreUsuario);
                if (usuarioEncontrado == null)
                {
                    context.Usuarios.Add(usuario);
                    context.SaveChanges();
                    return "El usuario ha sido agregado";
                }
                else
                {
                    return $"El usuario {usuario.NombreUsuario} ya existe";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string ModificarUsuario(Usuario usuario)
        {
            try
            {
                var listarUsuarios = context.Usuarios.ToList();
                var usuarioEncontrado = listarUsuarios.FirstOrDefault(x => x.NombreUsuario == usuario.NombreUsuario);
                if (usuarioEncontrado != null)
                {
                    context.Usuarios.Update(usuario);
                    context.SaveChanges();
                    return "El usuario ha sido modificado";
                }
                else
                {
                    return $"El usuario {usuario.NombreUsuario} no existe";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string EliminarUsuario(Usuario usuario)
        {
            try
            {
                var listarUsuarios = context.Usuarios.ToList();
                var usuarioEncontrado = listarUsuarios.FirstOrDefault(x => x.NombreUsuario == usuario.NombreUsuario);
                if (usuarioEncontrado != null)
                {
                    context.Usuarios.Remove(usuario);
                    context.SaveChanges();
                    return "El usuario ha sido eliminado";
                }
                else
                {
                    return $"El usuario {usuario.NombreUsuario} no existe";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string AsignarGrupoAUsuario(Usuario usuario, Grupo grupo)
        {
            try
            {
                var listarUsuarios = context.Usuarios.ToList();
                var usuarioEncontrado = listarUsuarios.FirstOrDefault(x => x.NombreUsuario == usuario.NombreUsuario);
                if (usuarioEncontrado == null)
                {
                    return $"El usuario {usuario.NombreUsuario} no existe";
                }
                if (usuarioEncontrado.Grupos.Any(g => g.CodigoGrupo == grupo.CodigoGrupo))
                {
                    return "El usuario ya pertenece a ese grupo";
                }
                var gruposExisten = context.Grupos.FirstOrDefault(g => g.CodigoGrupo == grupo.CodigoGrupo);
                if (gruposExisten == null)
                {
                    return "El grupo no existe en la base de datos";
                }

                usuarioEncontrado.Grupos.Add(gruposExisten);
                context.SaveChanges();
                return "El usuario ha sido asignado al grupo correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string QuitarGrupoAUsuario(Usuario usuario, Grupo grupo)
        {
            try
            {
                var listarUsuarios = context.Usuarios.ToList();
                var usuarioEncontrado = listarUsuarios.FirstOrDefault(x => x.NombreUsuario == usuario.NombreUsuario);
                if (usuarioEncontrado == null)
                {
                    return $"El usuario {usuario.NombreUsuario} no existe";
                }
                var listarGrupos = context.Grupos.ToList();
                var grupoEncontrado = listarGrupos.FirstOrDefault(g => g.CodigoGrupo == grupo.CodigoGrupo);
                if (grupoEncontrado == null)
                {
                    return "No se encontró el grupo en el usuario";
                }
                usuario.Grupos.Remove(grupo);
                context.SaveChanges();
                return "El grupo ha sido eliminado del usuario correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
