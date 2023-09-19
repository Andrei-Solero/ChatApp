﻿using ChatApp_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp_Controller
{
    public interface IMessageModel : IMessaging
    {
        int MessageID { get; set; }
        User MessageFrom { get; set; }
        User MessageTo { get; set; }
        DateTime DateSent { get; set; }
        TimeSpan TimeSent { get; set; }
        string MessageContent { get; set; }
        string MessageStatus { get; set; }
    }
}
