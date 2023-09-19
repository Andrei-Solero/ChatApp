using ChatApp_Model;
using ChatAppDataAccess;
using ChatApp_Controller.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp_Controller
{
    public class MessageProcessing : IMessage
    {
        IUsersView _usersView;
        UserProcessor dataProcessing;
        public MessageProcessing(IUsersView _usersView)
        {
            this._usersView = _usersView;
        }

        public List<MessageModel> GetMessages()
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@MainUserID", Value = _usersView.UserID
                },
                new SqlParameter()
                {
                    ParameterName = "@FriendUserID", Value = _usersView.UserFriend[0].UserID
                },
            };

            dataProcessing = new UserProcessor(parameters);
            return dataProcessing.GetMessages("spMessages_GetAllMessagesByID");
        }

        public void SendMessage()
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
            {
                new SqlParameter ()
                {
                    ParameterName = "@FromUser", Value = _usersView.UserMessage.MessageFrom.UserID
                },
                new SqlParameter ()
                {
                    ParameterName = "@ToUser", Value = _usersView.UserMessage.MessageTo.UserID
                },
                new SqlParameter ()
                {
                    ParameterName = "@DateSent", Value = _usersView.UserMessage.DateSent
                },
                new SqlParameter ()
                {
                    ParameterName = "@TimeSent", Value = _usersView.UserMessage.TimeSent
                },
                new SqlParameter ()
                {
                    ParameterName = "@UserMessage", Value = _usersView.UserMessage.MessageContent
                },
            };

            dataProcessing = new UserProcessor(sqlParameters);
            dataProcessing.InsertData("spMessages_InsertMessage");
        }
    }
}
