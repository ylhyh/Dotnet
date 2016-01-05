using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace VSolution.VAPI
{
    public class ApiControllerBase : ApiController
    {
        /* Instruction:
         * 1. Add NuGet package: Microsoft ASP.NET Web API Core Libraries.
         * 2. Add NuGet package: Microsoft ASP.NET Web API Client libraries.
         */
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
        }
    }
}
