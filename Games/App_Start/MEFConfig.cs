using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Games
{
    public static class MEFConfig
    {
        public static CompositionContainer Container { get; private set; }

        //Register the Games in the MEF container
        public static void RegisterMEF(MvcApplication app, string modulePath)
        {
            lock (app)
            {
                if (Container == null)
                {
                    var catalog = new AggregateCatalog();

                    catalog.Catalogs.Add(new AssemblyCatalog(Assembly.GetExecutingAssembly()));
                    catalog.Catalogs.Add(new DirectoryCatalog(modulePath, Properties.Settings.Default.GameModules));

                    Container = new CompositionContainer(catalog);
                }
            }
        }
    }
}