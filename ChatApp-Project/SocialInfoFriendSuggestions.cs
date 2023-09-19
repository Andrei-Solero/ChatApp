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
    public partial class SocialInfoFriendSuggestions : UserControl, IUserFriendProcessAdd
    {
        public SocialInfoFriendSuggestions(User availableUserData, User mainUser)
        {
            InitializeComponent();
            this.AvailableUserData = availableUserData;
            this.MainUserData = mainUser;
            controller = new UserController(this);

            lblName.Text = $"{availableUserData.FirstName} " +
                $"{availableUserData.MiddleName.Substring(0, 1).ToString()}. " +
                $"{availableUserData.LastName}";
            lblBio.Text = $"{availableUserData.Bio}";
            _ViewHelper.ImageProcessor(userImage, availableUserData.UserID);

            VerifiyStatus();
        }

        public User MainUserData 
        { get; set; }
        public User AvailableUserData 
        { get; set; }

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

        private void VerifiyStatus()
        {
            var areFriends = CheckFriendStatus();
            if (areFriends == 1) SetStatus_NotFriend();
            else if (areFriends == 2) SetStatus_RequestSent();
            else if (areFriends == 3) SetStatus_Friends();
        }

        public void AddFriend()
        {
            controller.AddFriend();
        }

        public int CheckFriendStatus()
        {
            return controller.CheckAvailableUserFriendStatus();
        }

        UserController controller;
        public void SetController(UserController controller)
        {
            this.controller = controller;
        }

        private void btnAddFriend_Click(object sender, EventArgs e)
        {
            AddFriend();
            VerifiyStatus();
        }
    }
}
