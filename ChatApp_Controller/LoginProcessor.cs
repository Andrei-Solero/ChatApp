using ChatApp_Model;
using ChatAppDataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp_Controller
{
    public class LoginProcessor : Repository
    {
        ILoginModel UserData;
        public LoginProcessor(ILoginModel UserData)
        {
            this.UserData = UserData;
        }

        public User GetDataByAccount()
        {
            User output = new User();
            this.Parameters.Add(new SqlParameter
            {
                ParameterName = "@Username",
                Value = UserData.UserName
            });
            this.Parameters.Add(new SqlParameter
            {
                ParameterName = "@Password",
                Value = UserData.Password
            });

            var data = this.ReadData("spUserAcount_GetUserDataByAccount");

            if (data.Read())
            {
                output = new User
                {
                    UserID = int.Parse(data["UserID"].ToString()),
                    FirstName = data["FirstName"].ToString(),
                    MiddleName = data["MiddleName"].ToString(),
                    LastName = data["LastName"].ToString(),
                    UserName = data["Username"].ToString(),
                    Password = data["UserPassword"].ToString(),
                };
            }

            this.cn.Close();
            this.Parameters.Clear();
            return output;
        }

    }
}
