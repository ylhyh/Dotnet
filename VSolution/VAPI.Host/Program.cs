using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSolution.VAPI.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Instruction:
             * 1. Add NuGet package: Microsoft.Owin.Hosting
             * 2. Add NuGet package: Microsoft.Owin.Host.HttpListener 
             * The Microsoft.Owin.Host.HttpListener assembly is a runtime reference in WebApp.Start. You need to include it in the project's references for it to be available for loading.
             */
            using (WebApp.Start(url: "http://localhost:8800"))
            {
                Console.WriteLine("API host is running...");
                Console.ReadLine();
            }
        }
    }
}
