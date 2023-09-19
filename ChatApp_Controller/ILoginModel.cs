using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp_Controller
{
    public interface ILoginModel : IAccessing
    {
        string UserName { get; set; }
        string Password { get; set; }
    }
}
