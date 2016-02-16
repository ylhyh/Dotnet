using Microsoft.Owin;
using Microsoft.Owin.Logging;
using Owin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using VSolution.Common;
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

            /*
             * Use GlobalConfiguration will occurs error: Value cannot be null. Parameter name: virtualPathRoot
             */
            //var config = GlobalConfiguration.Configuration;
            HttpConfiguration config = new HttpConfiguration();

            //config.MapHttpAttributeRoutes();

            //config.Configure(IocConfig.Register);
            IocConfig.Register(config);

            // Remove default XmlMediaTypeFormatter
            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());

            config.MessageHandlers.Add(new MessageHandler());
            //To do: remove Microsoft ASP.NET Web Api 2.2 WebHost from VAPI.Host, VAPI, VBusiness.
            /*
             * If VSolution.VAPI.dll exists in the bin folder, the dll will be loaded automatically after UseWebApi called. does not load assembly manually.
             */
            //var assemblyName = AssemblyName.GetAssemblyName(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "VSolution.VAPI.dll"));
            //AppDomain.CurrentDomain.Load(assemblyName);

            config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{action}/{id}", new { id = RouteParameter.Optional });
            appBuilder.UseWebApi(config);

            GlobalObject.HttpConfiguration = config;

            //appBuilder.Run(HandleRequest);

        }
        static Task HandleRequest(IOwinContext context)
        {
            context.Response.ContentType = "text/plain";
            return context.Response.WriteAsync("Hello, world!");
        }
    }
}
