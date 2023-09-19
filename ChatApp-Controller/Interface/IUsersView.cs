using ChatApp_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp_Controller.Interface
{
    public interface IUsersView : IViewModel, IMessage
    {
        void SetController(UserController controller);
        void RefreshMessages();
        void OpenMessage();
        void OpenFriends();
    }
}
