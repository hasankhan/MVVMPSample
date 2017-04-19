using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.MefExtensions;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;
using System.Diagnostics;

namespace PrismMVVMPStub
{
    class Bootstrapper: MefBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            var shell = this.Container.GetExportedValue<Shell>();
            return shell;
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (Shell) this.Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();

            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(Assembly.GetExecutingAssembly()));
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(SampleModule.SampleModule).Assembly));
        }
    }
}
