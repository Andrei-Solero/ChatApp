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
    public class MessageDashboardProcessor : Repository
    {
        User UserData;
        public MessageDashboardProcessor(User UserData)
        {
            this.UserData = UserData;
        }

        public List<User> UserFriend()
        {
            List<User> output = new List<User>();
            this.Parameters.Add(new SqlParameter
            {
                ParameterName = "@UserID", SqlValue = UserData.UserID
            });

            var data = this.ReadData("spUserFriend_GetUsersFriendByUserID");
            while (data.Read())
            {
                output.Add(new User
                {
                    UserID = int.Parse(data["UserFriendUserID"].ToString()),
                    FirstName = data["UserFriendFirstName"].ToString(),
                    MiddleName = data["UserFriendMiddleName"].ToString(),
                    LastName = data["UserFriendLastName"].ToString()
                });
            }

            this.cn.Close();
            this.Parameters.Clear();
            return output;
        }
    }
}
