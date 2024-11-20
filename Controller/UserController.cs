using Azure.Identity;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class UserController
    {
        UserContext context;
        public UserController() => context = new UserContext();

        public List<User> GetUser() => context.User.ToList();
        public bool AddUser(User user)
        {
            try
            {

                if (context.User.FirstOrDefault(x => x.Email == user.Email && x.Usernaem == user.Usernaem) == null)
                {
                    user.Password = user.Encrypt(user.Usernaem, user.Password);
                    context.User.Add(user);
                    return context.SaveChanges() > 0;
                }
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateUser(User user)
        {
            try
            {
                if (context.User.FirstOrDefault(x => x.Email == user.Email && x.Usernaem == user.Usernaem) == null)
                {
                    user.Password = user.Encrypt(user.Usernaem, user.Password);
                    context.User.Update(user);
                    return context.SaveChanges() > 0;
                }
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteUser(User user) {
            try
            {
                if (context.User.Any(x => x.IdUsuario == user.IdUsuario))
                {
                    context.User.Remove(user);
                    return context.SaveChanges() > 0;
                }
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
