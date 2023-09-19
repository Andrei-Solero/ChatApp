using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp_Controller
{
    public interface IUserFriendProcessAdd : IUserFriendProcess
    {
        void AddFriend();
        int CheckFriendStatus();
    }
}
