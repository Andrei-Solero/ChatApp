using ChatApp_Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp_Project
{
    public partial class CreateAccount : Form, IUserModel
    {
        public CreateAccount(LoginForm loginForm)
        {
            InitializeComponent();
            controller = new UserController(this);
            this.loginForm = loginForm;
        }

        #region Props

        public int UserID { get; set; }

        public string FirstName
        {
            get { return txtFirstName.Text; }
            set { txtFirstName.Text = value; }
        }
        public string MiddleName
        {
            get { return txtMiddleName.Text; }
            set { txtMiddleName.Text = value; }
        }
        public string LastName
        {
            get { return txtLastName.Text; }
            set { txtLastName.Text = value; }
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
        public string Bio
        {
            get { return txtBio.Text; }
            set { txtBio.Text = value; }
        }

        #endregion

        public void CreateUser()
        {
            int userID = controller.CreateUser();
            _ViewHelper.ImageProcessor_Save(profilePicture.ImageLocation, userID);
        }

        UserController controller;
        private readonly LoginForm loginForm;

        public void SetController(UserController controller)
        {
            this.controller = controller;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateUser();
            MessageBox.Show("WeChat Account Created! You can now login.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            loginForm.Show();
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK) 
            {
                profilePicture.Image = Image.FromFile(dialog.FileName);
                profilePicture.ImageLocation = dialog.FileName;
            }
        }
    }
}
