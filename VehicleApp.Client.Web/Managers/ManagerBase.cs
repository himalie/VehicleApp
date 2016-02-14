using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleApp.Client.Web.Managers
{
    public class ManagerBase
    {
        protected readonly ILogger Logger;

        public ManagerBase(ILogger logger)
        {
            Logger = logger;
        }
    }
}