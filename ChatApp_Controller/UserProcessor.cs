using ChatApp_Model;
using ChatAppDataAccess;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp_Controller
{
    public class UserProcessor : Repository
    {
        private IUserModel userProcessor;
        public UserProcessor(IUserModel userProcessor)
        {
            this.userProcessor = userProcessor;
        }

        public int CreateUser()
        {
            this.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@FirstName",
                Value = userProcessor.FirstName
            });
            this.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@MiddleName",
                Value = userProcessor.MiddleName
            });
            this.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@LastName",
                Value = userProcessor.LastName
            });
            this.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@Bio",
                Value = userProcessor.Bio
            });
            this.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@UserName",
                Value = userProcessor.UserName
            });
            this.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@UserPassword",
                Value = userProcessor.Password
            });

            this.Modify_InsertData("spUserAccount_CreateUserAndAccount");

            this.cn.Close();
            this.Parameters.Clear();
            return GetCreatedUser();
        }

        private int GetCreatedUser()
        {
            int fetchedUserID = 0;
            var data = this.ReadData("spUsers_GetLatestCreatedUser");

            if(data.Read() == true)
            {
                fetchedUserID = int.Parse(data["UserID"].ToString());
            }           

            this.cn.Close();
            this.Parameters.Clear();
            return fetchedUserID;
        }

    }
}
