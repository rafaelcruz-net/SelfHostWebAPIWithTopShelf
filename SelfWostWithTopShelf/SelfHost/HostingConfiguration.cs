using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace SelfHost
{
    public class HostingConfiguration: ServiceControl
    {
        private IDisposable _webApplication;

        public bool Start(HostControl hostControl)
        {
            Console.WriteLine("Iniciando o serviço");
            _webApplication = WebApp.Start<OwinConfiguration>("http://localhost:8089");
            Console.WriteLine("Serviço Iniciado");
            return true;
        }

        public bool Stop(HostControl hostControl)
        {
            Console.WriteLine("Terminando o serviço");
            _webApplication.Dispose();
            Console.WriteLine("Serviço terminado");
            return true;
        }

    }
}
