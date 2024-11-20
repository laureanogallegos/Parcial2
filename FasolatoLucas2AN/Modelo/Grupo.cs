using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Grupo
    {
        public int GrupoId { get; set; }
        public string Nombre { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }

        public Grupo()
        {
            Usuarios = new List<Usuario>();
        }
        //public bool AgregarUsuario(Usuario usuario)
        //{
        //    try
        //    {
        //        var usuarioExistente = Usuarios.FirstOrDefault(u => u.NombreUsuario == usuario.NombreUsuario || u.Email == usuario.Email);
        //        if (usuarioExistente == null)
        //        {
        //            Usuarios.Add(usuario);
        //            return true;
        //        }
        //        else return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}

        //public bool EliminarUsuario(Usuario usuario)
        //{
        //    try
        //    {
        //        var usuarioExistente = Usuarios.FirstOrDefault(u => u.NombreUsuario == usuario.NombreUsuario || u.Email == usuario.Email);
        //        if (usuarioExistente != null)
        //        {
        //            Usuarios.Remove(usuario);
        //            return true;
        //        }
        //        else return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}
    }
}
