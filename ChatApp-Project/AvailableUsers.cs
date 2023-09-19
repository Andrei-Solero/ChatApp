using ChatApp_Controller;
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
    public partial class AvailableUsers : UserControl, IUserFriendProcessAdd
    {
        public AvailableUsers(User UserFriendData, User MainUserData, AddFriend addFriendForm)
        {
            InitializeComponent();
            this.AvailableUserData = UserFriendData;
            this.MainUserData = MainUserData;
            this.addFriendForm = addFriendForm;
            controller = new UserController(this);
            
            this.lblUserName.Text = $"{ this.AvailableUserData.FirstName } { this.AvailableUserData.LastName }";
            _ViewHelper.ImageProcessor(userImage, UserFriendData.UserID);

            var areFriends = CheckFriendStatus();
            if (areFriends == 1) SetStatus_NotFriend();
            else if (areFriends == 2) SetStatus_RequestSent();
            else if (areFriends == 3) SetStatus_Friends();
        }

        private void SetStatus_Friends()
        {
            btnAddFriend.Text = "Friends";
            btnAddFriend.Image = ChatApp_Project.Properties.Resources.usercheck;
            btnAddFriend.Enabled = false;
        }

        private void SetStatus_NotFriend()
        {
            btnAddFriend.FillColor = Color.FromArgb(94, 148, 255);
            btnAddFriend.Text = "Add Friend";
            btnAddFriend.Image = ChatApp_Project.Properties.Resources.add;
        }

        private void SetStatus_RequestSent()
        {
            btnAddFriend.Enabled = false;
            btnAddFriend.FillColor = Color.FromArgb(94, 148, 255);
            btnAddFriend.Text = "Request Sent";
            btnAddFriend.Image = ChatApp_Project.Properties.Resources.requestSent;
        }

        private void SendData_Click(object sender, EventArgs e)
        {
            UserProfile profile = new UserProfile(this.AvailableUserData);
            addFriendForm.profilePanel.Controls.Clear();
            addFriendForm.profilePanel.Controls.Add(profile);
        }

        public User MainUserData { get; set; }
        public User AvailableUserData { get; set; }

        public void AddFriend()
        {
            controller.AddFriend();
        }

        UserController controller;
        private readonly AddFriend addFriendForm;

        public void SetController(UserController controller)
        {
            this.controller = controller;
        }

        private void btnAddFriend_Click(object sender, EventArgs e)
        {
            AddFriend();
        }

        public int CheckFriendStatus()
        {
            return controller.CheckAvailableUserFriendStatus();
        }
    }
}
