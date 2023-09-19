using ChatApp_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp_Controller.Interface
{
    public interface IMessage
    {
        void SendMessage();
        List<MessageModel> GetMessages();
    }
}
