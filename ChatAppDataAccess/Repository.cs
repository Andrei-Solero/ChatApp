using ChatApp_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ChatAppDataAccess
{
    public abstract class Repository : IRepository
    {
        public List<SqlParameter> Parameters { get; set; } = new List<SqlParameter>();
        public SqlConnection cn;

        public void Modify_InsertData(string sp)
        {
            using (cn = new SqlConnection(ConnectionString.Connection))
            using (SqlCommand command = new SqlCommand())
            {
                cn.Open();
                command.Connection = cn;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = sp;
                command.Parameters.AddRange(Parameters.ToArray());

                command.ExecuteNonQuery();
            }
        }

        public SqlDataReader ReadData(string sp)
        {
            cn = new SqlConnection(ConnectionString.Connection);
            SqlCommand command = new SqlCommand();

            cn.Open();
            command.Connection = cn;
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = sp;
            command.Parameters.AddRange(Parameters.ToArray());
            SqlDataReader reader = command.ExecuteReader();

            return reader;
        }
    }
}
