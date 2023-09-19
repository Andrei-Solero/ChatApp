using ChatApp_Model;
using ChatAppDataAccess;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ChatApp_Controller
{
    public class UsersAvailable : Repository
    {
        User MainUserData;
        public UsersAvailable(User mainUserData)
        {
            MainUserData = mainUserData;
        }

        public List<User> AllAvailableUsers()
        {
            List<User> users = new List<User>(); ;

            this.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@MainUserID",
                Value = MainUserData.UserID
            });

            var data = ReadData("spUsers_GetAllUserForMainUser");

            while (data.Read())
            {
                users.Add(new User
                {
                    UserID = int.Parse(data["UserID"].ToString()),
                    FirstName = data["FirstName"].ToString(),
                    MiddleName = data["MiddleName"].ToString(),
                    LastName = data["LastName"].ToString(),
                    Bio = data["Bio"].ToString()
                });
            }

            this.Parameters.Clear();
            this.cn.Close();
            return users;
        }

        public bool HasSentMainUserRequst(User availableUser)
        {
            bool hasSentRequest = false;

            this.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@MainUserID",
                Value = MainUserData.UserID
            });

            var data = ReadData("spUserFriend_GetFriendRequests");
            while (data.Read() == true)
            {
                if (int.Parse(data["FRFRomUserID"].ToString()) == availableUser.UserID) hasSentRequest = true;
            }

            this.Parameters.Clear();
            this.cn.Close();
            return hasSentRequest;
        }
    }
}
