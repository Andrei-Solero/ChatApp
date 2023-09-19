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
    public partial class LoginForm : Form, ILoginModel
    {
        public LoginForm()
        {
            InitializeComponent();
            controller = new UserController(this);
        }
        public string UserName
        { 
            get { return txtUsername.Text; } 
            set { txtUsername.Text = value; }
        }
        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        UserController controller;
        public User Login()
        {
            return controller.Login();
        }

        public void SetController(UserController controller)
        {
            this.controller = controller;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var userData = Login();

            if (userData.UserID == 0) MessageBox.Show("Account not Found. Please try again.", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                Dashboard dashboard = new Dashboard(userData, this);
                this.Hide();
                dashboard.Show();
            }
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            LoginForm form2 = new LoginForm();
            form2.Show();
        }

        private void btnCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccount create = new CreateAccount(this);
            create.Show();
            this.Hide();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();            
        }
    }
}
