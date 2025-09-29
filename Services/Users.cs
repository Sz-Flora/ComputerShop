using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ComputerShop.Services
{
    internal class Users : IDatabase
    {
        Connect conn = new Connect();
        public ICollection<object> GetAllData()
        {
            ICollection<object> data = new List<object>();

            conn._connection.Open();

            conn._connection.Close();

            return data;
        }

        public object GetData(string username, string password)
        {
            conn._connection.Open();

            string sql = "SELECT * FROM users WHERE UserName = @username AND Password = @password";

            conn._connection.Close();

            return new { message = " " };
        }
    }
}
