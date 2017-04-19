using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.Regions;

namespace PrismMVVMPSample.Infrastructure
{
    public class ModuleBase: IModule
    {
        protected IUnityContainer Container { get; private set; }
        protected IRegionViewRegistry RegionRegistry { get; private set; }

        public ModuleBase(IUnityContainer container, IRegionViewRegistry regionRegistry)
        {
            this.Container = container;
            this.RegionRegistry = regionRegistry;
        }

        public void Initialize()
        {
            ConfigureContainer();
            InitializeModule();
        }

        protected virtual void ConfigureContainer()
        {
        }

        protected virtual void InitializeModule()
        {
        }
    }
}
