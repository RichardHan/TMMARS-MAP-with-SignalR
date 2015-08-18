using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TMMARS_MAP_with_SignalR.Controllers
{
    public class AlertController : ApiController
    {
        [HttpGet]
        public string Send()
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<TMMARS_MAP_with_SignalR.MARSHub>();
            hubContext.Clients.All.alertFromServer("Test");
            return "Success";
        }
    }
}
