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
    public partial class MessageSentImage : UserControl
    {
        public MessageSentImage(MessageModel message)
        {
            InitializeComponent();

            _ViewHelper.ChatImageProcessor(sentImage, message.MessageContent);
        }
    }
}
