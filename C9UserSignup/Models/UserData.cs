using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C9UserSignup.Models
{
    public class UserData
    {
        static private List<User> users = new List<User>();

        public static List<User> GetAll()
        {
            return users;
        }

        public static void Add(User newUser)
        {
            users.Add(newUser);
        }

        public static void Remove(int id)
        {
            User userToRemove = GetById(id);
            users.Remove(userToRemove);
        }

        public static User GetById(int id)
        {
            return users.Single(x => x.UserId == id);
        }

        public static bool VerifyPassword(string username, string verify)
        {
            return username.Equals(verify);
        }

    }
}
