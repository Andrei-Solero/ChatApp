using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using Guna.UI2.WinForms;
using ChatApp_Model;

namespace ChatApp_Project
{
    public partial class Dashboard : Form
    {
        private readonly LoginForm login;
        public Dashboard(User userData, LoginForm login)
        {
            InitializeComponent();
            MessageDashboard messageDashboard = new MessageDashboard(userData, this);
            wrapper.Controls.Add(messageDashboard);
            this.login = login;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.Show();
        }
    }
}
