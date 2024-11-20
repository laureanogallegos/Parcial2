using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        private List<Rol> roles;
        public User() => roles = new List<Rol>();
        public bool Status { get; set; }
        public string Email { get; set; }
        public int IdUsuario { get; set; }
        public string Usernaem { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

		public List<Rol> Roles
		{
			get { return roles; }
			set { roles = value; }
		}

		public string Password { get; set; }

		public ICollection<Rol> GetRol() => roles;

        public string Encrypt(string username, string password)
		{
			Rfc2898DeriveBytes rfcDelivery = new Rfc2898DeriveBytes(Encoding.UTF8.GetBytes(password), Encoding.UTF8.GetBytes(username),10000);
			var key = rfcDelivery.GetBytes(32);
			return Convert.ToBase64String(key);
		}
	}
}
