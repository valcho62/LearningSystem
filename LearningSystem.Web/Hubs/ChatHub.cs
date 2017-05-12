 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace LearningSystem.Web.Hubs
{
    public class ChatHub : Hub
    {
        public void GetMessage(string username,string message)
        {
            Clients.All.getMessage(username,message);
        }
    }
}