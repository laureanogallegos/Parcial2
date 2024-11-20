using System.Collections.ObjectModel;

namespace MODELO
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
        public bool Estado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<Grupos> Grupos;
        private Usuarios()
        {
            Grupos = new List<Grupos>();
        }
        public ReadOnlyCollection<Grupos> grupos
        {
            get => grupos.AsReadOnly();
        }
        public string AgregarGrupo(Grupos grupo)
        {
            var grupoEncontrado = grupos.FirstOrDefault(x => x.Id == grupo.Id);
            if(grupoEncontrado == null)
            {
                Grupos.Add(grupo);
                return "Se agrego el grupo";
            }
            else
            {
                return null;
            }

        }
        public string EliminarGrupo(Grupos grupo)
        {
            var grupoEncontrado = grupos.FirstOrDefault(x => x.Id == grupo.Id);
            if(grupoEncontrado != null)
            {
                Grupos.Remove(grupo);
                return "Se elimino el grupo";
            }
            else
            {
                return null;
            }
        }



    }
}
