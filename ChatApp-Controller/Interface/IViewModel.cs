using ChatApp_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp_Controller.Interface
{
    public interface IViewModel
    {
        int UserID { get; set; }
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        List<User> UserFriend { get; set; }
        MessageModel UserMessage { get; set; }
    }
}
