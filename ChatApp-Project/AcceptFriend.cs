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
    public partial class AcceptFriend : Form, IUserFriendProcessRequests
    {
        public AcceptFriend(User mainUserData, Dashboard dashboard)
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
            AvailableFriendRequests FRForm;
            foreach (var friendRequest in friendRequests)
            {
                FRForm = new AvailableFriendRequests(friendRequest, MainUserData);
                userContainer.Controls.Add(FRForm);
            }
        }

        UserController controller;
        private readonly Dashboard dashboard;

        public void SetController(UserController controller)
        {
            this.controller = controller;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dashboard.Opacity = 1;
            this.Close();            
        }
    }
}
