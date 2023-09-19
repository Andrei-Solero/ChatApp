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
    public partial class MessageReceived : UserControl
    {
        public MessageReceived(MessageModel message)
        {
            InitializeComponent();
            this.label1.Text = message.MessageContent;
            _ViewHelper.ImageProcessor(userImage, message.MessageFrom.UserID);
        }
    }
}
