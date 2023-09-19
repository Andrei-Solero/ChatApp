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
    public partial class SocialsFriendSuggestions : UserControl, IUserInterface
    {
        public SocialsFriendSuggestions(User MainUserData, MessageDashboard mainDashboard)
        {
            InitializeComponent();
            this.MainUserData = MainUserData;
            this.mainDashboard = mainDashboard;
            controller = new UserController(this);

            ShowData();
        }

        public User MainUserData 
        { get; set; }
        

        UserController controller;
        private readonly MessageDashboard mainDashboard;

        public void SetController(UserController controller)
        {
            this.controller = controller;
        }

        public List<User> ShowUsers()
        {
            return controller.ShowAllAvailableUsers();
        }

        private void ShowData()
        {
            var availableUsers = ShowUsers();
            SocialInfoFriendSuggestions socialInfo;
            foreach (var user in availableUsers)
            {
                if (controller.HasSentMainUserRequest(user) != true)
                {
                    socialInfo = new SocialInfoFriendSuggestions(user, MainUserData);
                    availableUsersContainer.Controls.Add(socialInfo);
                }
            }

        }

        private void linkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainDashboard.ResetMenu();
        }
    }
}
