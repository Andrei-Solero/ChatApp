using ChatApp_Controller;
using ChatApp_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis.TtsEngine;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp_Project
{
    public partial class RecentMessage : UserControl, IRecentMessage
    {
        MessageDashboard messageDashboard;
        public RecentMessage(User userFriend, User userMain, MessageDashboard messageDashboard)
        {
            InitializeComponent();
            SetEvents();

            controller = new UserController(this);
            this.MessageFrom = userMain;
            this.MessageTo = userFriend;

            this.messageDashboard = messageDashboard;
            _ViewHelper.ImageProcessor(userImage, userFriend.UserID);            
            chatRefresher.Enabled = true;
        }

        #region Events

        private void SetEvents()
        {
            List<Label> labels = this.Controls.OfType<Label>().ToList();
            foreach (Label item in labels)
            {
                item.Click += Control_Click;
                item.MouseEnter += Item_MouseHover;
                item.MouseLeave += Item_MouseLeave;
            }

            userImage.Click += Control_Click;
            userImage.MouseEnter += Item_MouseHover;
            userImage.MouseLeave += Item_MouseLeave;

            statusNotif.Click += Control_Click;
            statusNotif.MouseEnter += Item_MouseHover;
            statusNotif.MouseLeave += Item_MouseLeave;

            this.Click += Control_Click;
            this.MouseEnter += Item_MouseHover;
            this.MouseLeave += Item_MouseLeave;
        }

        private void Item_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void Item_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(187, 191, 195);
        }
        public void Control_Click(object sender, EventArgs e)
        {
            if (statusNotif.Visible == true) UpdateRecentMessageStatus();
            
            MessageForm message = new MessageForm(MessageTo, MessageFrom);
            messageDashboard.Controls.Add(message);
            message.BringToFront();
        }

        #endregion

        private void MessageStatus(MessageModel MessageData)
        {
            if (MessageData.MessageStatus == "Sent")
            {
                lblUserName.Font = new Font("Segoe UI Semilight", 15f, FontStyle.Bold);
                lblRecentMessage.ForeColor = Color.FromArgb(23, 112, 230);
                statusNotif.Visible = true;
                
            }
            else
            {
                lblUserName.Font = new Font("Segoe UI Semilight", 15f, FontStyle.Regular);
                lblRecentMessage.ForeColor = Color.Gray;
                lblRecentMessage.Font = new Font("Segoe UI Semilight", 12f, FontStyle.Regular);
                statusNotif.Visible = false;
            }
        }

        private void LoadMessageInfo()
        {
            var MessageData = GetRecentMessage();
            lblUserName.Text = $"{ MessageTo.FirstName } { MessageTo.MiddleName } { MessageTo.LastName }";
            lblDateSent.Text = MessageData.DateSent.ToString("dddd");
            lblTimeSent.Text = MessageData.TimeSent.ToString();
            lblRecentMessage.Text = MessageData.MessageContent;

            if (MessageData.MessageFrom == null || MessageData.MessageTo == null)
            {
                lblRecentMessage.Text = "You got a new friend. Chat now!";
                lblRecentMessage.ForeColor = Color.FromArgb(23, 112, 230);
                lblUserName.Font = new Font("Segoe UI Semilight", 15f, FontStyle.Bold);
            }
            else
            {
                if (MessageData.MessageFrom.UserID == this.MessageFrom.UserID)
                {
                    lblRecentMessage.Text = $"You: {MessageData.MessageContent}";
                }
                else
                {
                    lblRecentMessage.Text = $"{this.MessageTo.FirstName}: {MessageData.MessageContent}";
                    MessageStatus(MessageData);
                }
            }
        }        

        public User MessageFrom 
        { get; set; }
        public User MessageTo 
        { get; set; }

        
        public MessageModel GetRecentMessage()
        {
            return controller.MessageViewer();
        }

        public void UpdateRecentMessageStatus()
        {
            controller.UpdateMessageStatus();
        }

        UserController controller;
        public void SetController(UserController controller)
        {
            this.controller = controller;
        }

        private void chatRefresher_Tick(object sender, EventArgs e)
        {
            LoadMessageInfo();
        }
    }
}

