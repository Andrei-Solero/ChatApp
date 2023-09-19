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
    public class MessageProcessor : Repository
    {
        IMessageModel UsersView;
        public MessageProcessor(IMessageModel UsersView)
        {
            this.UsersView = UsersView;
        }
        public void InsertMessageData()
        {
            this.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@FromUser",
                Value = UsersView.MessageFrom.UserID
            });
            this.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@ToUser",
                Value = UsersView.MessageTo.UserID
            });
            this.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@DateSent",
                Value = UsersView.DateSent
            });
            this.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@TimeSent",
                Value = UsersView.TimeSent
            });
            this.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@UserMessage",
                Value = UsersView.MessageContent
            });

            this.Modify_InsertData("spMessages_InsertMessage");
            this.Parameters.Clear();
            this.cn.Close();
        }

        public List<MessageModel> ActiveMessages()
        {
            List<MessageModel> output = new List<MessageModel>();

            this.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@MainUserID",
                Value = UsersView.MessageFrom.UserID
            });
            this.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@FriendUserID",
                Value = UsersView.MessageTo.UserID
            });

            var data = ReadData("spMessages_GetAllMessagesByID");

            while (data.Read())
            {
                output.Add(new MessageModel
                {
                    MessageID = int.Parse(data["ID"].ToString()),
                    DateSent = DateTime.Parse(data["DateSent"].ToString()),
                    MessageContent = data["UserMessage"].ToString(),
                    TimeSent = TimeSpan.Parse(data["TimeSent"].ToString()),
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
                    },
                    MessageStatus = data["MessageStatus"].ToString()
                });
            }

            this.cn.Close();
            this.Parameters.Clear();
            return output;
        }       

        public void UpdateMessageStatus()
        {
            MessageViewProcessor viewProcessor = new MessageViewProcessor();
            viewProcessor.UpdateMessageStatus();
        }

    }
}
