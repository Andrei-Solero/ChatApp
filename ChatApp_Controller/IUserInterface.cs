using ChatApp_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp_Controller
{
    public interface IUserInterface : IUsersView
    {
        User MainUserData { get; set; }

        List<User> ShowUsers();        
    }
}
