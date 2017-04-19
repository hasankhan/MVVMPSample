using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.UnityExtensions;
using System.Windows;
using Microsoft.Practices.Prism.Modularity;

namespace PrismMVVMPStub
{
    class Bootstrapper: UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            var shell = Container.Resolve<Shell>();
            shell.Show();
            return shell;
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            var catalog = new ModuleCatalog();

            catalog.AddModule(typeof(SampleModule.SampleModule));

            return catalog;
        }
    }
}
