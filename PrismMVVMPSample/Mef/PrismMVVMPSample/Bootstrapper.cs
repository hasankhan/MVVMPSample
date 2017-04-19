using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.MefExtensions;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace PrismMVVMPSample
{
    class Bootstrapper: MefBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            var shell = Container.GetExportedValue<Shell>();
            return shell;
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (Shell)Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();

            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(Assembly.GetExecutingAssembly()));
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(LEDModule.LEDModule).Assembly));
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(KeypadModule.KeypadModule).Assembly));
        }
    }
}
