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

            MySqlCommand commandChoose = new MySqlCommand("SELECT * FROM `" + TableName +"` WHERE `" + first + "` = @f AND `"+ second + "` = @s", connection);
            commandChoose.Parameters.Add("@f", MySqlDbType.VarChar).Value = valueFirst;
            commandChoose.Parameters.Add("@s", MySqlDbType.VarChar).Value = valueSecond;

            adapter.SelectCommand = commandChoose;
            adapter.Fill(table);

            return table.Rows.Count;
        }


        public int Find(string TableName, string first, string valueFirst)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand commandChoose = new MySqlCommand("SELECT * FROM `" + TableName + "` WHERE `" + first + "` = @f", connection);
            commandChoose.Parameters.Add("@f", MySqlDbType.VarChar).Value = valueFirst;

            adapter.SelectCommand = commandChoose;
            adapter.Fill(table);

            return table.Rows.Count;
        }

        public int Find(string TableName, string column)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand commandChoose = new MySqlCommand("SELECT `" + column + "` FROM `" + TableName + "`", connection);

            adapter.SelectCommand = commandChoose;
            adapter.Fill(table);

            return table.Rows.Count;
        }

        public string[] GetAll(string TableName, string column)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand commandChoose = new MySqlCommand("SELECT `" + column + "` FROM `" + TableName + "`", connection);

            adapter.SelectCommand = commandChoose;
            adapter.Fill(table);

            var values = new string[table.Rows.Count];

            table.Rows.CopyTo(values, 0);
            return values;
        }

        public int Add(string TableName, string first, string second, string valueFirst, string valueSecond)
        {
            MySqlCommand commandADD = new MySqlCommand("INSERT INTO `"+ TableName + "`(`" + first + "`, `" + second + "`) VALUES (@f, @s)", connection);
            commandADD.Parameters.Add("@f", MySqlDbType.VarChar).Value = valueFirst;
            commandADD.Parameters.Add("@s", MySqlDbType.VarChar).Value = valueSecond;

            OpenConnection();

            int IsItExist = commandADD.ExecuteNonQuery();

            CloseConnection();

            return IsItExist;
        }
    }
}
