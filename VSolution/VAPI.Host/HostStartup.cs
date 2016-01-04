using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSolution.VAPI.Host
{
    class HostStartup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            //appBuilder.Run(HandleRequest);
        }
        static Task HandleRequest(IOwinContext context)
        {
            context.Response.ContentType = "text/plain";
            return context.Response.WriteAsync("Hello, world!");
        }
    }
}
