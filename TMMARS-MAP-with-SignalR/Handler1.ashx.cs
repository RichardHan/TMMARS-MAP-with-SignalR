using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TMMARS_MAP_with_SignalR
{
    /// <summary>
    /// Summary description for Handler1
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<TMMARS_MAP_with_SignalR.MARSHub>();
            hubContext.Clients.All.alertFromServer("Test");

            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}