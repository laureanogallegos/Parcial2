using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controladora
{
    public class GestionarUsuarios
    {
        private UsuariosContext contexto { get; set; }
        public GestionarUsuarios(UsuariosContext contexto)
        {
            this.contexto = contexto;
        }
        /*
        private string Encrypt(string usuario, string clave)
        {
            var saltBytes = Encoding.UTF8.GetBytes(usuario);
            var passwordBytes = Encoding.UTF8.GetBytes(clave);

            var rfc2898DeriveBytes = new RfcDerivedBytes(passwordBytes, saltBytes, 10000);
            var key = rfc2898DeriveBytes.GetBytes(32);

            return Convert.ToBase64String(key);
        }*/

        public bool AgregarUsuario(Usuario usuario) {

            try
            {
                var usuarioExistente = contexto.Usuarios.FirstOrDefault(m => m.NombreUsuario == usuario.NombreUsuario);
                if (usuarioExistente == null)
                {

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;

        }
    }
}
