using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraUsuarios
    {
        Context _context;

        public ControladoraUsuarios()
        {
            _context = new Context();
        }

        public List<Usuario> listarUsuarios()
        {
            return _context.Usuarios.ToList();
        }
        public List<Grupo> listargrupos()
        {
            return _context.Grupos.ToList();
        }

        public bool AgregarUsuario(Usuario usuario)
        {
            try
            {
                var Nombreusuarioexiste = _context.Usuarios.FirstOrDefault(p => p.NombreDeUsuario == usuario.NombreDeUsuario);
                var MailExiste = _context.Usuarios.FirstOrDefault(p => p.NombreDeUsuario == usuario.NombreDeUsuario);
                if (Nombreusuarioexiste == null && MailExiste == null)
                {
                    _context.Add(usuario);
                    return _context.SaveChanges() > 0;

                }
                else return false;


            }
            catch (Exception ex)
            {
                return false;
            }

        }
       
        public bool ModificarUsuario(Usuario usuario)
        {
            try
            {
                var usuarioexiste = _context.Usuarios.FirstOrDefault(p => p.Mail == usuario.Mail);
                if (usuarioexiste != null)
                {
                    _context.Update(usuario);
                    return _context.SaveChanges() > 0;

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
                var usuarioexiste = _context.Usuarios.FirstOrDefault(p => p.Mail == usuario.Mail);
                if (usuarioexiste != null)
                {
                    _context.Update(usuario);
                    return _context.SaveChanges() > 0;

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
