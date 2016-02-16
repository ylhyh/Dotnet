using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace VSolution.Common
{
    public static class GlobalObject
    {
        public static HttpConfiguration HttpConfiguration
        {
            get;
            set;
        }
    }
}
