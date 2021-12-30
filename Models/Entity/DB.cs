using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entity
{
    public class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=catfeeder");

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public int Find(string TableName, string first, string second, string valueFirst, string valueSecond)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand commandChooseUser = new MySqlCommand("SELECT * FROM `" + TableName +"` WHERE `" + first + "` = @f AND `"+ second + "` = @s", connection);
            commandChooseUser.Parameters.Add("@f", MySqlDbType.VarChar).Value = valueFirst;
            commandChooseUser.Parameters.Add("@s", MySqlDbType.VarChar).Value = valueSecond;

            adapter.SelectCommand = commandChooseUser;
            adapter.Fill(table);

            return table.Rows.Count;
        }


        public int Find(string TableName, string first, string valueFirst)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand commandChooseUser = new MySqlCommand("SELECT * FROM `" + TableName + "` WHERE `" + first + "` = @f", connection);
            commandChooseUser.Parameters.Add("@f", MySqlDbType.VarChar).Value = valueFirst;

            adapter.SelectCommand = commandChooseUser;
            adapter.Fill(table);

            return table.Rows.Count;
        }

        public int Add(string TableName, string first, string second, string valueFirst, string valueSecond)
        {
            MySqlCommand commandChooseUser = new MySqlCommand("INSERT INTO `"+ TableName + "`(`" + first + "`, `" + second + "`) VALUES (@f, @s)", connection);
            commandChooseUser.Parameters.Add("@f", MySqlDbType.VarChar).Value = valueFirst;
            commandChooseUser.Parameters.Add("@s", MySqlDbType.VarChar).Value = valueSecond;

            OpenConnection();

            int IsItExist = commandChooseUser.ExecuteNonQuery();

            CloseConnection();

            return IsItExist;
        }
    }
}
