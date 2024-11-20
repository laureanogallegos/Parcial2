using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string NombreUsuario {  get; set; }
        public string Email { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Boolean Estado { get; set; }
        public string Clave { get; set; }
        public ICollection<Grupo> Grupos { get; set; }

        public Usuario()
        {
            Grupos = new List<Grupo>();
        }

        //public bool AgregarGrupo(Grupo grupo)
        //{
        //    try
        //    {
        //        var grupoExistente = Grupos.FirstOrDefault(g => g.GrupoId == grupo.GrupoId);
        //        if (grupoExistente == null)
        //        {
        //            Grupos.Add(grupo);
        //            return true;
        //        }
        //        else return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}

        //public bool EliminarGrupo(Grupo grupo)
        //{
        //    try
        //    {
        //        var grupoExistente = Grupos.FirstOrDefault(g => g.GrupoId == grupo.GrupoId);
        //        if (grupoExistente != null)
        //        {
        //            Grupos.Remove(grupo);
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
