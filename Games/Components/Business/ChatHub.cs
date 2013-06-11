using System;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Games.Components.Business
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            if (!string.IsNullOrWhiteSpace(message))            
                Clients.All.broadcastMessage(name, message);
        }
    }
}