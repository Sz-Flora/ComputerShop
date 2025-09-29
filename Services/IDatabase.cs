using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Services
{
    internal interface IDatabase
    {
        ICollection<object> GetAllData();
        object GetData(string username, string password);
    }
}
