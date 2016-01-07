using Microsoft.Owin;
using Microsoft.Owin.Logging;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace VSolution.VAPI.Host.Startup
{
    [assembly: OwinStartupAttribute(typeof(HostStartup))]

    public class HostStartup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            /*
             * Instruction:
             * 1. Add NuGet package: Microsoft.AspNet.WebApi.Core
             * 2. Add NuGet package: Microsoft.AspNet.WebApi.Owin
             */
            HttpConfiguration config = new HttpConfiguration();

            IocConfig.Register(config);

            //appBuilder.Run(HandleRequest);

        }
        static Task HandleRequest(IOwinContext context)
        {
            context.Response.ContentType = "text/plain";
            return context.Response.WriteAsync("Hello, world!");
        }
    }
}
