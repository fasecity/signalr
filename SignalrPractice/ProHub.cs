using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalrPractice
{
    public class ProHub : Hub
    {
        public void Announce(string message)
        {
            Clients.All.announce(message);
        }
    }
}