using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace HostelSystem_TestWebApp
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //Console.Write(Newtonsoft.Json.JsonSerializer.Create().Serialize(Console.Out, new Models.Reservation()));
        }
    }
}
