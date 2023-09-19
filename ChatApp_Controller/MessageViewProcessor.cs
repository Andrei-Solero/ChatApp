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
    public class MessageViewProcessor : Repository
    {

        IRecentMessage RecentMessageModel;
        public MessageViewProcessor(IRecentMessage RecentMessageModel)
        {
            this.RecentMessageModel = RecentMessageModel;
        } 

        public MessageViewProcessor()
        {

        }

        public MessageModel GetRecentMessage()
        {
            MessageModel messageModel;
            this.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@MainUserID",
                Value = RecentMessageModel.MessageFrom.UserID
            });
            this.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@FriendUserID",
                Value = RecentMessageModel.MessageTo.UserID
            });

            var data = ReadData("spMessages_GetRecentMessageByID");

            if (data.Read() == true)
            {
                messageModel = new MessageModel
                {
                    MessageID = int.Parse(data["ID"].ToString()),
                    DateSent = DateTime.Parse(data["DateSent"].ToString()),
                    MessageContent = data["UserMessage"].ToString(),
                    TimeSent = TimeSpan.Parse(data["TimeSent"].ToString()),
                    MessageStatus = data["MessageStatus"].ToString(),
                    MessageFrom = new User
                    {
                        UserID = int.Parse(data["UserID"].ToString()),
                        FirstName = data["UserFirstName"].ToString(),
                        MiddleName = data["UserMiddleName"].ToString(),
                        LastName = data["UserLastName"].ToString()
                    },
                    MessageTo = new User
                    {
                        UserID = int.Parse(data["UserFriendUserID"].ToString()),
                        FirstName = data["UserFriendFirstName"].ToString(),
                        MiddleName = data["UserFriendMiddleName"].ToString(),
                        LastName = data["UserFriendLastName"].ToString()
                    }
                };
            }
            else messageModel = new MessageModel();

            this.cn.Close();
            this.Parameters.Clear();
            return messageModel;
        }

        public void UpdateMessageStatus()
        {
            this.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@MainUserID",
                Value = RecentMessageModel.MessageFrom.UserID
            });
            this.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@FriendUserID",
                Value = RecentMessageModel.MessageTo.UserID
            });

            this.Modify_InsertData("spMessages_UpdateMessageStatus");
            this.Parameters.Clear();
            this.cn.Close();
        }

    }
}
