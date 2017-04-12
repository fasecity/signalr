using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using SignalrPractice.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SignalrPractice
{
    /// <summary>
    /// hub name "chat" is the alias being shown to public api.
    /// client is access point to push back data to client
    /// </summary>
    [HubName("chat")]
    
    public class ChatHub : Hub
    {
        public void SendMessage(string message)
        {
            // Instantiate the ASP.NET Identity system
            ApplicationUser c = new ApplicationUser();
            //string x = c.displayName;
          


            //var usr = User.Identity.Name;
            //do the same thing call clients inside of hub
            //Clients.Caller.newMessage(message);
            //Clients.Client(Context.ConnectionId).newMessage(message);

            ////to call evreyone exept broadcaster use other
            //Clients.Others.All.
            //var msg = String.Format("{0} :{1}", x, message);
            var msg = String.Format("{0} :{1}", Context.ConnectionId, message);

            Clients.All.newMessage(msg);
        }
        public void JoinRoom(string room)
        {
            //NOTE this is not persistant
            Groups.Add(Context.ConnectionId,room);
        }
        public void sendMessageToRoom(string room, string message)
        {
            var msg = String.Format("{0} :{1}", Context.ConnectionId, message);

            Clients.Group(room).newMessage(msg);
        }
        public void SendMessageData(SendData data)
        {
            //process incomming data
            //transform dAta
            //make new data
            Clients.All.newData(data);
        }
        //public Task<int> SendDataAsync()
        //{
        //    //async work
        //   
        //}

        public override Task OnConnected()
        {
            SendMonitoringData("Connected", Context.ConnectionId);
            return base.OnConnected();
        }

        //public override Task OnDisconnected()
        //{
        //    SendMonitoringData("Disconnected", Context.ConnectionId);
        //    return base.OnDisconnected();
        //}

        public override Task OnReconnected()
        {
            SendMonitoringData("Reconnected", Context.ConnectionId);
            return base.OnReconnected();
        }

        private void SendMonitoringData(string eventType, string connection)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<MonitorHub>();
            context.Clients.All.newEvent(eventType, connection);
        }
    }

    public class SendData
    {
        public int Id { get; set; }
        public string Data { get; set; }
    }

}
