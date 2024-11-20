using System.Text;

namespace Modelo
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; } 

        public Grupo Grupos { get; set; }
        

        
    }
}
