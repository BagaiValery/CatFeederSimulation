using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Enity
{
    public class UserDB : DB
    {
        DB db = new DB();
        public int FindUser (string LoginUser, string PassUser)
        {
            DataTable Usertable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand commandChooseUser = new MySqlCommand("SELECT * FROM 'users' WHERE 'login' = @uL AND 'pass' = @uP", db.GetConnection());
            commandChooseUser.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginUser;
            commandChooseUser.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PassUser;

            adapter.SelectCommand = commandChooseUser;
            adapter.Fill(Usertable);

            return Usertable.Rows.Count;
        }

        public int AddUser(string LoginUser, string PassUser)
        {
            MySqlCommand commandChooseUser = new MySqlCommand("INSERT INTO 'users' ('login', 'pass') VALUES (@uL, @uP)", db.GetConnection());
            commandChooseUser.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginUser;
            commandChooseUser.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PassUser;

            db.OpenConnection();

            int IsItExist = commandChooseUser.ExecuteNonQuery();

            db.CloseConnection();

            return IsItExist;
        }
    }
}
