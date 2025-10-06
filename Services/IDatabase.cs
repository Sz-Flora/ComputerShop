using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.Services
{
    internal interface IDatabase
    {
        DataView GetAllData();
        bool GetData(string username, string password);
        object AddRecord(string username, string password, string email, string fullname);
        object DeleteUser(object id);
        object UpdateUser(object user);
    }
}
