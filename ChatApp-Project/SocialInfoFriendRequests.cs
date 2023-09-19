using ChatApp_Controller;
using ChatApp_Model;
using Guna.UI2.AnimatorNS;
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
    public partial class SocialInfoFriendRequests : UserControl, IUserFriendProcessAccept
    {
        public SocialInfoFriendRequests(User MainUserData, User AvailableUserData)
        {
            InitializeComponent();

            this.MainUserData = MainUserData;
            this.AvailableUserData = AvailableUserData;

            _ViewHelper.ImageProcessor(userImage, MainUserData.UserID);
            lblName.Text = $"{MainUserData.FirstName} {MainUserData.MiddleName.Substring(0, 1)}. {MainUserData.LastName}";

            controller = new UserController(this);
        }

        public User MainUserData
        { get; set; }
        public User AvailableUserData
        { get; set; }

        public void AcceptFriend()
        {
            controller.Accept();
        }

        UserController controller;
        public void SetController(UserController controller)
        {
            this.controller = controller;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            AcceptFriend();
            this.btnAccept.Enabled = false;
            this.btnAccept.Text = "Friends";
        }
    }
}
