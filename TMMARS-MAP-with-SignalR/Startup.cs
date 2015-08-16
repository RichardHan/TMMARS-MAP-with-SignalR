using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TMMARS_MAP_with_SignalR.Startup))]
namespace TMMARS_MAP_with_SignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            app.MapSignalR();
            //app.MapSignalR("/signalr", new HubConfiguration());
        }
    }
}
