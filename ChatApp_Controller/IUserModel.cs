using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp_Controller
{
    public interface IUserModel : IUserProcessor
    {
        int UserID { get; set; }
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string Bio { get; set; }
    }
}
