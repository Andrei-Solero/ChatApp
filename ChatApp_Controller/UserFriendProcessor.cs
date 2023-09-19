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
    public class UserFriendProcessor : Repository
    {
        User MainUserData;
        User FriendUserData;

        public UserFriendProcessor(User mainUserData, User friendUserData)
        {
            MainUserData = mainUserData;
            FriendUserData = friendUserData;
        }

        public UserFriendProcessor(User mainUserData)
        {
            this.MainUserData = mainUserData;
        }

        public void AddFriendToDB()
        {
            this.Parameters.Add(new SqlParameter
            {
                ParameterName = "@MainUser",
                Value = MainUserData.UserID
            });
            this.Parameters.Add(new SqlParameter
            {
                ParameterName = "@AvailableUser",
                Value = FriendUserData.UserID
            });

            Modify_InsertData("spUserFriend_AddFriend");

            this.cn.Close();
            this.Parameters.Clear();
        }

        public int CheckAvailableUserFriendStatus()
        {
            /* if statusIndicator is equal to 1 : the UserFriendStatus is not Friend
             * if statusInidcator is equal to 2 : the UserFriendStatus is Friend Request Sent
             * if statusInidcaotr is equal to 3 : the UserFriendStatus is Friend
             */
            int statusIndicator = 0;
            int counter = 0;

            this.Parameters.Add(new SqlParameter
            {
                ParameterName = "@MainUser",
                Value = MainUserData.UserID
            });
            this.Parameters.Add(new SqlParameter
            {
                ParameterName = "@AvailableUser",
                Value = FriendUserData.UserID
            });

            var data = ReadData("spUserFriend_CheckUserFriendStatus");
            while(data.Read() == true)
            {
                counter++;
            }

            if (counter == 0) statusIndicator = 1;
            else if (counter == 1) statusIndicator = 2;
            else if (counter == 2) statusIndicator = 3;

            this.cn.Close();
            this.Parameters.Clear();
            return statusIndicator;
        }

        public List<User> GetFriendRequests()
        {
            List<User> friendRequests = new List<User>();
            this.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@MainUserID",
                Value = MainUserData.UserID
            });

            var data = this.ReadData("spUserFriend_GetFriendRequests");

            while (data.Read() == true)
            {
                friendRequests.Add(new User
                {
                    UserID = int.Parse(data["FRFRomUserID"].ToString()),
                    FirstName = data["FRFromFirstName"].ToString(),
                    MiddleName = data["FRFromMiddleName"].ToString(),
                    LastName = data["FRFromLastName"].ToString()
                });
            }

            this.cn.Close();
            this.Parameters.Clear();
            return friendRequests;
        }

        public void AcceptRequest()
        {
            this.Parameters.Add(new SqlParameter
            {
                ParameterName = "@MainUser",
                Value = FriendUserData.UserID
            });
            this.Parameters.Add(new SqlParameter
            {
                ParameterName = "@RequestUser",
                Value = MainUserData.UserID
            });

            Modify_InsertData("spUserFriend_AcceptFriendRequest");

            this.cn.Close();
            this.Parameters.Clear();
        }

    }
}
