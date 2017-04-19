using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using System.ComponentModel.Composition.Hosting;
using Microsoft.Practices.ServiceLocation;

namespace PrismMVVMPStub.Infrastructure
{
    public class ModuleBase : IModule
    {
        protected IServiceLocator Container { get; private set; }
        protected IRegionViewRegistry RegionRegistry { get; private set; }

        public ModuleBase(IServiceLocator container, IRegionViewRegistry regionRegistry)
        {
            this.Container = container;
            this.RegionRegistry = regionRegistry;
        }

        public void Initialize()
        {
            InitializeModule();
        }

        protected virtual void InitializeModule()
        {
        }
    }
}
