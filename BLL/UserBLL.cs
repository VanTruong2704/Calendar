using Calendar.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.BLL
{
    public class UserBLL
    {
        public static User CurrentUser { get; set; }

        public static bool login(string name, string email)
        {
            User u = UserDAL.GetUser(email);
            if (u == null) return false;

            if (u.Name !=  name) return false;

            CurrentUser = u;
            return true;
        }

        public static bool register(string name, string email)
        {
            User u = UserDAL.GetUser(email);
            if (u != null) return false;
            u = new User();
            u.Name = name;
            u.Email = email;

            return UserDAL.AddUser(u);
        }
    }
}
