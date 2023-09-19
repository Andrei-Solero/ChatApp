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
    public partial class AddFriend : Form, IUserInterface
    {
        public AddFriend(User MainUserData, Dashboard dashboard)
        {
            InitializeComponent();
            this.MainUserData = MainUserData;
            this.dashboard = dashboard;
            controller = new UserController(this);            

            AvailableUsers users;
            foreach (var User in ShowUsers())
            {
                users = new AvailableUsers(User, MainUserData, this);
                userContainer.Controls.Add(users);
            }

            this.userContainer.VerticalScroll.Visible = false;
        }

        public User MainUserData { get; set; }

        UserController controller;
        private readonly Dashboard dashboard;

        public void SetController(UserController controller)
        {
            this.controller = controller;
        }

        public List<User> ShowUsers()
        {
            return controller.ShowAllAvailableUsers();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dashboard.Opacity = 1;
            this.Close();            
        }

        public List<User> ListOfFriendRequests()
        {
            throw new NotImplementedException();
        }
    }
}
