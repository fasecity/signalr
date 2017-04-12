using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalrPractice
{
    public class MyHub1 : Hub
    {
       
        // This is in-memory .. persist as per needs.
        private static List<MapClient> ConnectedClientsList = new List<MapClient>();

        public void ShowClientOnMap(MapClient clientToShowOnMap)
        {
            // Add client & broadcast location to all clients connected to this Hub.
            ConnectedClientsList.Add(clientToShowOnMap);
            Clients.All.addMapClient(clientToShowOnMap);
        }

        public void RemoveClientFromMap(MapClient clientToRmeoveFromMap)
        {
            // Clean-up.
            ConnectedClientsList.Remove(clientToRmeoveFromMap);
            Clients.All.removeMapClient(clientToRmeoveFromMap);
        }


    }
    public class MapClient
    {
        public string ClientId { get; set; }
        public Location ClientLocation { get; set; }

        public class Location
        {
            public float Latitude { get; set; }
            public float Longitude { get; set; }

        }

    }

   
}