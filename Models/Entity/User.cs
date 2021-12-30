using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entity
{
    public class User
    {
        public string Login { get; set; }
        public string Pass { get; set; }

        public User(string login, string password)
        {
            Login = login;
            Pass = password;
        }

        //public int MessFind()
        //{
        //    DB userdb = new DB();
        //    return userdb.Find("users", "login", "password", Login, Pass);
        //}

        //public int MessAdd()
        //{
        //    DB userdb = new DB();
        //    return userdb.Add("users", "login", "password", Login, Pass);
        //}
    }
}
