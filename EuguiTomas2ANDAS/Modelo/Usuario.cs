namespace Modelo
{
    public class Usuario
    {
        public string Id { get; set; }
        public string NombreDeUsuario {  get; set; } 
        public string Email { get; set; }
        public string Clave {  get; set; }
        public bool Estado {  get; set; } 
        public string Nombre { get; set; }
        public string Apellido {  get; set; }

        public List<Grupo> Grupos { get; set; }

        public Usuario()
        {
            Grupos = new List<Grupo>();

        }
    }
}
