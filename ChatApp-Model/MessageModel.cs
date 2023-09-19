using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp_Model
{
    public class MessageModel
    {
        public int MessageID { get; set; }
        public User MessageFrom { get; set; }
        public User MessageTo { get; set; }
        public DateTime DateSent { get; set; }
        public TimeSpan TimeSent { get; set; }
        public string MessageContent { get; set; }
        public string MessageStatus { get; set; }
    }
}
