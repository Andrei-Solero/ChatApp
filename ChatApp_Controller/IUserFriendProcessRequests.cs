using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp_Controller
{
    public interface IUserFriendProcessRequests : IUserFriendProcess
    {
        void GetFriendRequests();
    }
}
