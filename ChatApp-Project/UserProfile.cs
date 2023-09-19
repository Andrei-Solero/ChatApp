using ChatApp_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp_Project
{
    public partial class UserProfile : UserControl
    {
        public UserProfile(User user)
        {
            InitializeComponent();

            this.lblName.Text = $"{user.FirstName} {user.MiddleName.Substring(0, 1).ToUpper()} {user.LastName}";
            this.lblBio.Text = $@"'{user.Bio}'";
            _ViewHelper.ImageProcessor(this.profilePicture, user.UserID);
        }
    }
}
