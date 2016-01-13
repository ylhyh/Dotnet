using Microsoft.Owin;
using Microsoft.Owin.Logging;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using VSolution.VAPI.Host.Startup;

[assembly: OwinStartupAttribute(typeof(HostStartup))]

namespace VSolution.VAPI.Host.Startup
{
    public class HostStartup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            /*
             * Instruction:
             * 1. Add NuGet package: Microsoft.AspNet.WebApi.Core
             * 2. Add NuGet package: Microsoft.AspNet.WebApi.Owin
             * 3. Uses GlobalConfiguration need to add package: Microsoft.AspNet.WebApi.WebHost (System.Web.Http.WebHost)
             */
            //HttpConfiguration config = new HttpConfiguration();
            GlobalConfiguration.Configure(IocConfig.Register);
            //IocConfig.Register(config);
            appBuilder.UseWebApi(GlobalConfiguration.Configuration);
            //appBuilder.Run(HandleRequest);

        }
        static Task HandleRequest(IOwinContext context)
        {
            context.Response.ContentType = "text/plain";
            return context.Response.WriteAsync("Hello, world!");
        }
    }
}
