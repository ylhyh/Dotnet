﻿using Autofac;
using Autofac.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace VSolution.VAPI.Host.Startup
{
    public class IocConfig
    {
        public static void Register(HttpConfiguration configuration)
        {
            ContainerBuilder containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule(new ConfigurationSettingsReader("autofac","autofac.config"));
            containerBuilder.Build();
        }
    }
}
