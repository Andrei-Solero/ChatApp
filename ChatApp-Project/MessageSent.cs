using ChatApp_Controller;
using ChatApp_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp_Project
{
    public partial class MessageSent : UserControl
    {

        public MessageSent(MessageModel model)
        {
            InitializeComponent();
            this.txtMessageSent.Text = model.MessageContent;
        }
        
    }
}
