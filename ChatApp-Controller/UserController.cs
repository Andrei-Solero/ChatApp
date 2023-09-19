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
    public class UserController
    {
        IUsersView _usersView;
        IMessage messageProcessor;
        UserProcessor dataProcess;
        public UserController(IUsersView usersView)
        {
            _usersView = usersView;
            messageProcessor = new MessageProcessing(usersView);
            usersView.SetController(this);
        }

        public void SendMessage()
        {
            messageProcessor.SendMessage();
        }

        public List<MessageModel> GetMessages()
        {
            return messageProcessor.GetMessages();
        }

        public void CreateNewUser()
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@FirstName", Value = _usersView.FirstName
                },
                new SqlParameter()
                {
                    ParameterName = "@MiddleName", Value = _usersView.MiddleName
                },
                new SqlParameter()
                {
                    ParameterName = "@LastName", Value = _usersView.LastName
                },
            };

            dataProcess = new UserProcessor(parameters);
            dataProcess.InsertData("spUsers_CreateNewUser");
        }
    }
}
