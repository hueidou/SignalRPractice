using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRPractice.ServerMonitor
{
    public class ServerMonitorHub : Hub
    {
        private readonly Ticker _ticker;

        public ServerMonitorHub() : this(Ticker.Instance)
        { }

        public ServerMonitorHub(Ticker ticker)
        {
            _ticker = ticker;
        }


        public void JoinGroup(string serverIP)
        {
            _ticker.JoinGroup(Context.ConnectionId, serverIP);
        }
    }
}