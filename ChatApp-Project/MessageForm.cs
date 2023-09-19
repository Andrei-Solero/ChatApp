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
using System.Windows.Input;

namespace ChatApp_Project
{
    public partial class MessageForm : UserControl, IMessageModel
    {
        public MessageForm(User userFriendData, User mainUserData)
        {
            InitializeComponent();
            this.MessageTo = userFriendData;
            this.MessageFrom = mainUserData;

            controller = new UserController(this);
            _ViewHelper.ImageProcessor(userFriendImage, MessageTo.UserID);

            lblUserFriendName.Text = $"{userFriendData.FirstName} {userFriendData.LastName }";
            GetAllMessages(controller.GetActiveMessages());
        }

        public int MessageID 
        { get; set; }
        public DateTime DateSent
        { get => DateTime.Now; set => DateSent = DateTime.Now.Date; }
        public TimeSpan TimeSent
        { get => DateTime.Now.TimeOfDay; set => TimeSent = DateTime.Now.TimeOfDay; }
        public User MessageFrom 
        { get; set; }
        public User MessageTo
        { get; set; }
        public string MessageContent
        {
            get { return txtMessage.Text; }
            set { txtMessage.Text = value; }
        }
        public string MessageStatus { get; set; }

        UserController controller;

        public void SendMessage()
        {
            _ViewHelper.MessageStatus = "Sent";
            _ViewHelper.AudioSend();
            controller.SendMessage();
        }

        MessageSent formSent;
        MessageReceived formReceived;
        MessageSentImage formSentImage;
        MessageReceivedImage formReceivedImage;

        public void GetAllMessages(List<MessageModel> allMessages)
        {
            foreach (var message in allMessages)
            {   
                _FormMessagingProcessor formProcessor = new _FormMessagingProcessor(messages, message, this);
                formProcessor.MessagingFormValidation(formSentImage, formSent, formReceivedImage, formReceived);
            }

            messageCounter = allMessages.Count;
        }

        public void SetController(UserController controller)
        {
            this.controller = controller;
        }

        int messageCounter = 0;
        public void GetRecentMessage(List<MessageModel> allMessages)
        {
            if (allMessages.Count > 0)
            {
                var recentMessage = allMessages[allMessages.Count - 1];
                if (messageCounter < allMessages.Count)
                {
                    _FormMessagingProcessor formProcessor = new _FormMessagingProcessor(messages, recentMessage, this);
                    formProcessor.MessagingFormValidation(formSentImage, formSent, formReceivedImage, formReceived);

                    messageCounter = allMessages.Count;
                }
            }            
        }
        private void messageDataIdentifier_Tick(object sender, EventArgs e)
        {
            GetRecentMessage(controller.GetActiveMessages());
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMessage.Text) == false)
            {
                _ViewHelper.ChatImageProcessor_Save(sendImageFilePath, MessageContent);
                SendMessage();
                messageDataIdentifier_Tick(sender, e);
                txtMessage.Clear();
                linkClearImage.Visible = false;
                sendImage.Image = null;                
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void UpdatingMessageStatusWhenOpen()
        {
            _ViewHelper.MessageStatus = "Seen";
            controller.MessageStatusUpdating();
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtMessage.Text.Length > 0)
            {
                btnSend_Click(sender, e);
                txtMessage.Clear();
            }            
        }

        string sendImageFilePath = "";
        private void sendImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                MessageContent = $"img_{MessageFrom.UserID}-{MessageTo.UserID}_" +
                    $"{DateSent.ToShortDateString()}" +
                    $"{DateTime.Parse(TimeSent.ToString()).ToString("HH:mm:ss")}";
                sendImage.Image = Image.FromFile(dialog.FileName);
                sendImageFilePath = dialog.FileName;
                linkClearImage.Visible = true;
            }
        }

        private void linkClearImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sendImage.Image = null;
            linkClearImage.Visible = false;
            txtMessage.Clear();
            messages.VerticalScroll.Value = messages.VerticalScroll.Maximum;
        }
    }
}
