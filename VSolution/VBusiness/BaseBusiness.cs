using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Dependencies;
using Autofac;

namespace VSolution.VBusiness
{
    public class BaseBusiness
    {
        internal IDependencyResolver Resolver
        {
            get
            {
                return GlobalConfiguration.Configuration.DependencyResolver;
            }
        }
    }
}
