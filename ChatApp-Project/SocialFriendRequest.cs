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
    public partial class SocialFriendRequest : UserControl, IUserFriendProcessRequests
    {
        public SocialFriendRequest(User mainUserData, MessageDashboard dashboard)
        {
            InitializeComponent();
            this.MainUserData = mainUserData;
            this.dashboard = dashboard;
            controller = new UserController(this);
        }

        public User MainUserData 
        { get; set; }
        public User AvailableUserData 
        { get; set; }

        public void GetFriendRequests()
        {
            var friendRequests = controller.FriendRequests();
            SocialInfoFriendRequests FRForm;
            foreach (var friendRequest in friendRequests)
            {
                FRForm = new SocialInfoFriendRequests(friendRequest, MainUserData);
                availableUsersContainer.Controls.Add(FRForm);
            }
        }

        UserController controller;
        private readonly MessageDashboard dashboard;

        public void SetController(UserController controller)
        {
            this.controller = controller;
        }

        private void linkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dashboard.ResetMenu();
        }
    }
}
