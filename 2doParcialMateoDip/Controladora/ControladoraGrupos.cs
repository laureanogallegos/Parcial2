using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraGrupos
    {
        Contexto contexto = new Contexto();

        public bool AgregarGrupo(Grupo nuevoGrupo)
        {
            var busqueda = contexto.Grupos.FirstOrDefault(x=>x.CodigoGrupo == nuevoGrupo.CodigoGrupo);
            if(busqueda == null)
            {
                contexto.Grupos.Add(nuevoGrupo);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
        public bool EliminarGrupo(Grupo nuevoGrupo)
        {
            var busqueda = contexto.Grupos.FirstOrDefault(x => x.CodigoGrupo == nuevoGrupo.CodigoGrupo);
            if (busqueda != null)
            {
                contexto.Grupos.Remove(nuevoGrupo);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
        public bool ModificarGrupo(Grupo nuevoGrupo)
        {
            var busqueda = contexto.Grupos.FirstOrDefault(x => x.CodigoGrupo == nuevoGrupo.CodigoGrupo);
            if (busqueda != null)
            {
                contexto.Grupos.Update(nuevoGrupo);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public ReadOnlyCollection<Grupo> ListarGrupo()
        {
            return contexto.Grupos.ToList().AsReadOnly();
        }
    }
}
