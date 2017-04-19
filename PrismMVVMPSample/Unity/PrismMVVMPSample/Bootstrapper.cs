using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity;
using System.Windows;
using Microsoft.Practices.Prism.Modularity;

namespace PrismMVVMPSample
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

            catalog.AddModule(typeof(LEDModule.LEDModule));
            catalog.AddModule(typeof(KeypadModule.KeypadModule));

            return catalog;
        }
    }
}
