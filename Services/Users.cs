using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ComputerShop.Services
{
    internal class Users : IDatabase
    {
        Connect conn = new Connect();

        public object AddRecord(string username, string password, string email, string fullname)
        {
            conn._connection.Open();

            string sql = "INSERT INTO `users` (`UserName`, `FullName`, `Password`, `Email`) VALUES (@username, @fullname, @password, @email)";

            MySqlCommand cmd = new MySqlCommand(sql, conn._connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@fullname", fullname);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@email", email);

            cmd.ExecuteNonQuery();

            conn._connection.Close();

            return new { message = "Sikeres regisztráció!" };
        }

        public DataView GetAllData()
        {
            conn._connection.Open();

            string sql = "SELECT * FROM users";

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn._connection);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            conn._connection.Close();

            return dt.DefaultView;
        }

        public object GetData(string username, string password)
        {
            conn._connection.Open();

            string sql = "SELECT * FROM users WHERE UserName = @username AND Password = @password";

            MySqlCommand cmd = new MySqlCommand(sql, conn._connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue ("@password", password);

            MySqlDataReader reader = cmd.ExecuteReader();

            string result = "";
            if (reader.Read() == true)
                result = "Regisztrált tag";
            else
                result = "Nem regisztrált tag";

            conn._connection.Close();

            return new { message = result };
        }
    }
}
