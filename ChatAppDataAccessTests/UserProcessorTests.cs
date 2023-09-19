using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChatAppDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatApp_Model;
using ChatApp_Controller;
using ChatApp_Controller.Interface;
using System.Data.SqlClient;

namespace ChatAppDataAccess.Tests
{
    [TestClass()]
    public class UserProcessorTests
    {
        [TestMethod()]
        public void InsertDataTest()
        {
            IUsersView s = new Sample();
            s.UserMessage = new MessageModel
            {
                MessageFrom = new User
                {
                    UserID = 1000
                },
                MessageTo = new User
                {
                    UserID = 1001
                },
                MessageContent = "WWWIWIWIWIW",
                DateSent = DateTime.Now,
                TimeSent = DateTime.Now.TimeOfDay
            };

            MessageProcessing p = new MessageProcessing(s);
            p.SendMessage();
            
            //List<SqlParameter> parameters = new List<SqlParameter>()
            //{
            //    new SqlParameter()
            //    {
            //        ParameterName = "@FromUser",
            //        Value = s.UserMessage.MessageFrom.UserID
            //    },
            //    new SqlParameter()
            //    {
            //        ParameterName = "@ToUser",
            //        Value = s.UserMessage.MessageTo.UserID
            //    },
            //    new SqlParameter()
            //    {
            //        ParameterName = "@DateSent",
            //        Value = s.UserMessage.DateSent
            //    },
            //    new SqlParameter()
            //    {
            //        ParameterName = "@TimeSent",
            //        Value = s.UserMessage.TimeSent
            //    },
            //    new SqlParameter()
            //    {
            //        ParameterName = "@UserMessage",
            //        Value = s.UserMessage.MessageContent
            //    },
            //};
            //MessageProcessing pr = new MessageProcessing(s);
            ////UserController controller = new UserController(s);
            //UserProcessor processor = new UserProcessor(parameters);

            //processor.InsertData("spMessages_InsertMessage");
        }
    }

    public class Sample : IUsersView
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<User> UserFriend { get; set; }

        public MessageModel UserMessage { get; set; }

        public List<MessageModel> GetMessages()
        {
            throw new NotImplementedException();
        }

        public void OpenFriends()
        {
            throw new NotImplementedException();
        }

        public void OpenMessage()
        {
            throw new NotImplementedException();
        }

        public void RefreshMessages()
        {
            throw new NotImplementedException();
        }

        public void SendMessage()
        {
            throw new NotImplementedException();
        }

        public void SetController(UserController controller)
        {
            throw new NotImplementedException();
        }
    }
}