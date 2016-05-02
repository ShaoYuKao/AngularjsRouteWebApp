using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace AngularjsRouteWebApp.Hubs
{
    public class MyHub : Hub
    {
        public void Hello(string msg)
        {
            Clients.All.show(msg);
        }
    }
}