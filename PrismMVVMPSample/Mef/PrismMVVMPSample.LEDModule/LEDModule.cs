using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Regions;
using PrismMVVMPSample.Infrastructure;
using PrismMVVMPSample.LEDModule.LED;
using Microsoft.Practices.Prism.MefExtensions.Modularity;
using Microsoft.Practices.ServiceLocation;
using System.ComponentModel.Composition;

namespace PrismMVVMPSample.LEDModule
{
    [ModuleExport(typeof(LEDModule))]
    public class LEDModule: ModuleBase
    {
        [ImportingConstructor]
        public LEDModule(IServiceLocator container, IRegionViewRegistry regionRegistry) : base(container, regionRegistry)
        {

        }

        protected override void InitializeModule()
        {
            base.InitializeModule();

            RegionRegistry.RegisterViewWithRegion(RegionNames.LEDRegion, () => Container.GetInstance<IPresenter<ILEDView>>().View);
        }
    }
}
