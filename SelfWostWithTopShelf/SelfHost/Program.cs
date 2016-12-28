﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.Service<HostingConfiguration>();
                x.RunAsLocalSystem();
                x.SetDescription("Owin with Webapi as Windows service");
                x.SetDisplayName("selfhost.owin.webapi");
                x.SetServiceName("selfhost.owin.webapi");
            });
            
        }
    }
}
