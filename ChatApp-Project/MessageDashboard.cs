using ChatApp_Controller;
using ChatApp_Model;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ChatApp_Project
{
    public partial class MessageDashboard : UserControl, IUserChatInterface
    {
        public MessageDashboard(User MainUserData, Dashboard mainDashboard)
        {
            InitializeComponent();
            
            this.MainUserData = MainUserData;
            this.mainDashboard = mainDashboard;
            controller = new UserController(this);

            _ViewHelper.ImageProcessor(userImage, MainUserData.UserID);

            LoadRecentMessage();

            friendRequestToolTip.SetToolTip(btnFriendRequest, "Friend Requests/Friends");
            addFriendToolTip.SetToolTip(btnAddFriend, "Add Friend");
            logoutToolTip.SetToolTip(btnLogout, "Logout Account");

            this.noConvo = panelNoChat;
        }

        private void LoadRecentMessage()
        {
            var friends = ShowUsers();
            if (friends.Count > 0)
            {
                this.contentContainer.Controls.Remove(panelNoChat);

                foreach (var item in friends)
                {
                    RecentMessage recent = new RecentMessage(item, this.MainUserData, this);
                    contentContainer.Controls.Add(recent);
                }
            }
            else contentContainer.Controls.Add(noConvo);

            friendCounter = friends.Count;
        }

        private void LoadRecentFriend(List<User> friends)
        {
            if (friendCounter < friends.Count)
            {
                if (friends.Count > 0)
                {
                    this.contentContainer.Controls.Remove(panelNoChat);
                    RecentMessage recent;
                    contentContainer.Controls.Clear();

                    foreach (var friend in friends)
                    {
                        recent = new RecentMessage(friend, MainUserData, this);                        
                        contentContainer.Controls.Add(recent);

                    }
                }
                //var recentFriend = friends[friends.Count - 1];
                //RecentMessage recent = new RecentMessage(recentFriend, this.MainUserData, this);
                //if (friends.Count > 0)
                //{
                //    this.contentContainer.Controls.Remove(panelNoChat);
                //    contentContainer.Controls.Clear();
                //    contentContainer.Controls.Add(recent);
                //    _ViewHelper.AudioNewFriend();
                //}
            }

            friendCounter = friends.Count;
        }

        public User MainUserData { get; set; }
        UserController controller;
        private readonly Dashboard mainDashboard;
        private int friendCounter = 0;
        private Panel noConvo;

        public void SetController(UserController controller)
        {
            this.controller = controller;
        }

        public List<User> ShowUsers()
        {
            return controller.ShowUserFriends();
        }

        private void chatRefresher_Tick(object sender, EventArgs e)
        {
            var allUsers = ShowUsers();
            LoadRecentFriend(allUsers);

            if (ListOfFriendRequests().Count > 0)
            {
                friendRequestCount.Visible = true;
                friendRequestCount.FillColor = Color.Red;
                friendRequestCount.Size = new Size(20, 20);
                friendRequestCount.Text = ListOfFriendRequests().Count.ToString();
            }
            else
            {
                friendRequestCount.Visible = false;
            }
        }

        private void addFriend_Clicked(object sender, EventArgs e)
        {
            SocialsFriendSuggestions suggestions = new SocialsFriendSuggestions(this.MainUserData, this);
            contentContainer.AutoScroll = false;
            contentContainer.Controls.Clear();
            contentContainer.Controls.Add(suggestions);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Guna2MessageDialog dialog = new Guna2MessageDialog
            {
                Icon = MessageDialogIcon.Question,
                Caption = "Logout Account",
                Buttons = MessageDialogButtons.YesNo,
                Text = "Are you sure you want to logout?",
                Style = MessageDialogStyle.Light,
                Parent = (Dashboard)this.Parent.Parent
            };

            DialogResult logout = dialog.Show();
            if (logout == DialogResult.Yes)
            {
                mainDashboard.Close();
            }
        }

        private void btnFriendRequest_Click(object sender, EventArgs e)
        {
            SocialFriendRequest friendRequests = new SocialFriendRequest(this.MainUserData, this);
            contentContainer.AutoScroll = false;
            contentContainer.Controls.Clear();
            contentContainer.Controls.Add(friendRequests);
        }

        private void logo_Click(object sender, EventArgs e)
        {
            mainDashboard.WindowState = FormWindowState.Minimized;
        }

        public List<User> ListOfFriendRequests()
        {
            return controller.FriendRequests();
        }

        public void ResetMenu()
        {
            contentContainer.Controls.Clear();
            contentContainer.AutoScroll = true;
            LoadRecentMessage();
        }
    }
}
