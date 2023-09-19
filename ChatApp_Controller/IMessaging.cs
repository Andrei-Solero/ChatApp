using ChatApp_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp_Controller
{
    public interface IMessaging : IUsersView
    {
        void SendMessage();
        void GetAllMessages(List<MessageModel> messages);
        void UpdatingMessageStatusWhenOpen();
    }
}
