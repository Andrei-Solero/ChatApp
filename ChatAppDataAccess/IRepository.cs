using ChatApp_Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppDataAccess
{
    public interface IRepository
    {
        List<SqlParameter> Parameters { get; set; }
        SqlDataReader ReadData(string sp);
        void Modify_InsertData(string sp);
    }
}
