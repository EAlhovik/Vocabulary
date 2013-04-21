using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SignalR.Hubs;

namespace Vocabulary.Hubs
{
    public class Chat : Hub
    {
        public void SendMessage(string nick, string message)
        {
            Clients.PublishMessage(nick, message);
        }
    }
}