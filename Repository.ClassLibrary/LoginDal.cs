using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Entity;

namespace Electronica.Repository
{
   public class LoginDal
    {
        ElectronicaContext context = new ElectronicaContext();
        public User CheckLogin(User objLogin)
        {
            bool status = false;
            User objProfile = new User();
            List<User> userlist=context.Users.ToList();
            User user=userlist.Find(p => p.Email == objLogin.Email);              
            if (user.Password==objLogin.Password)
            {
                status= true;
            }
            if (status)
            {
                return user;
            }
            else
            {
                user.Email = null;
                return user;
            }
        }
    }
}
