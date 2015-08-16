using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Net;

namespace TMMARS_MAP_with_SignalR
{
    public class MARSHub : Hub
    {
        //public void Send(string name, string message)
        //{
        //    Clients.All.addNewMessageToPage(name, message);
        //}


        public void Updatedots()
        {
            using (WebClient wc = new WebClient())
            {
                string result = wc.DownloadString("https://njdc.rest.mars.trendmicro.com/akamailog/base?" + RandomNum());
                Clients.All.updatedots(result);
            }
        }

        public void UpdatetopApp()
        {
            using (WebClient wc = new WebClient())
            {
                string result = wc.DownloadString("https://njdc.rest.mars.trendmicro.com/akamailog/top-app?" + RandomNum());
                Clients.All.updatetopApp(result);
            }
        }

        public void UpdatetopVirus()
        {
            using (WebClient wc = new WebClient())
            {
                string result = wc.DownloadString("https://njdc.rest.mars.trendmicro.com/akamailog/top-virus?" + RandomNum());
                Clients.All.updatetopVirus(result);
            }
        }

        public void Updatenews()
        {
            using (WebClient wc = new WebClient())
            {
                string result = wc.DownloadString("https://njdc.rest.mars.trendmicro.com/akamailog/log?" + RandomNum());
                Clients.All.updatenews(result);
            }
        }

        public void Updatecircles()
        {
            using (WebClient wc = new WebClient())
            {
                string result = wc.DownloadString("https://njdc.rest.mars.trendmicro.com/akamailog/latest?rnd?" + RandomNum());
                Clients.All.updatecircles(result);
            }
        }

        public void UpdateDailyNumber()
        {
            using (WebClient wc = new WebClient())
            {
                string result = wc.DownloadString("https://njdc.rest.mars.trendmicro.com/akamailog/daily-scanned-number?rnd?" + RandomNum());
                Clients.All.updateDailyNumber(result);
            }
        }

        private int RandomNum()
        {
            return new Random().Next(100000, 999999);
        }
    }
}