namespace Modelo
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string Email { get; set; }
        public string Clave {  get; set; }
        public string Estado { get; set; }
        public string NombreYApellido { get; set; }
        public ICollection<Grupo> GruposAsociados { get; set; }

        public Usuario()
        {
            GruposAsociados = new List<Grupo>();
        }
    }
}
