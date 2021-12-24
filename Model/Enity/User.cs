using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Enity
{
    public class User
    {
        public string Login {get; set;}
        public string Pass { get; set; }

        public User (string login, string password)
        {
            Login = login;
            Pass = password;
        }

        public int MessFind()
        {
            UserDB userdb = new UserDB();
            return userdb.FindUser(Login, Pass);
        }

        public int MessAdd ()
        {
            UserDB userdb = new UserDB();
            return userdb.AddUser(Login, Pass);
        }
    }
}
