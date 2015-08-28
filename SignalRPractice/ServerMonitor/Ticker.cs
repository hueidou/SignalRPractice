using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRPractice.ServerMonitor
{
    public class Ticker
    {
        // 单例模式
        private readonly static Lazy<Ticker> _instance = new Lazy<Ticker>(
            () => new Ticker(GlobalHost.ConnectionManager.GetHubContext<ServerMonitorHub>().Clients,
                GlobalHost.ConnectionManager.GetHubContext<ServerMonitorHub>().Groups));


        private readonly ConcurrentDictionary<string, ServerMonitorInfo> _stocks = new ConcurrentDictionary<string, ServerMonitorInfo>();

        private Ticker(IHubConnectionContext<dynamic> clients, IGroupManager groups)
        {
            Clients = clients;
            Groups = groups;
        }

        public static Ticker Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        private IGroupManager Groups
        {
            get; set;
        }

        private IHubConnectionContext<dynamic> Clients
        {
            get;
            set;
        }

        /// <summary>
        /// Client加入Group
        /// </summary>
        /// <param name="connectionId">The connection identifier.</param>
        /// <param name="serverIP">The server ip.</param>
        public void JoinGroup(string connectionId, string serverIP)
        {
            // 加入serverIP对应的Group
            // 不用从原来的Group移除？
            Groups.Add(connectionId, serverIP);

            Clients.Group(serverIP);
        }
    }
}