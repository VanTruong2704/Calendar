using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.DAL
{
    public class UserDAL
    {
        public static List<User> GetUsers()
        {
            using (var db = DataContextFactory.CreateContext())
            {
                var q = from p in db.Users
                        select p;
                return q.ToList();
            }
        }

        public static User GetUser(string email)
        {
            using (var db = DataContextFactory.CreateContext())
            {
                var q = db.Users.Where(p => p.Email == email);
                return q.FirstOrDefault();
            }
        }

        public static bool AddUser(User user)
        {
            using (var db = DataContextFactory.CreateContext())
            {
                try
                {
                    db.Users.InsertOnSubmit(user);
                }
                catch (Exception e)
                {
                    return false;
                }
                finally
                {
                    db.SubmitChanges();
                }
                return true;
            }
        }

        public static bool UpdateUser(User user)
        {
            using (var db = DataContextFactory.CreateContext())
            {
                var q = db.Users.Where(p => p.Id == user.Id);
                User u = q.FirstOrDefault();
                if (u == null) return false;
                u.Name = user.Name;
                u.Email = user.Email;

                try
                {
                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    return false;
                }
                return true;
            }
        }

        public static bool DeleteUser(int userId)
        {
            using (var db = DataContextFactory.CreateContext())
            {
                var q = db.Users.Where(p => p.Id == userId);
                User u = q.FirstOrDefault();

                if (u == null) return false;

                try
                {
                    db.Users.DeleteOnSubmit(u);
                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    return false;
                }

                return true;
            }
        }
    }
}
