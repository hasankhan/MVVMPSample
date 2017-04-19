using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using PrismMVVMPSample.Infrastructure;
using PrismMVVMPSample.LEDModule.LED;

namespace PrismMVVMPSample.LEDModule
{
    public class LEDModule: ModuleBase
    {
        public LEDModule(IUnityContainer container, IRegionViewRegistry regionRegistry) : base(container, regionRegistry)
        {

        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            Container.RegisterType<ILEDView, LEDView>();
            Container.RegisterType<IPresenter<ILEDView>, LEDPresenter>();
        }

        protected override void InitializeModule()
        {
            base.InitializeModule();

            RegionRegistry.RegisterViewWithRegion(RegionNames.LEDRegion, () => Container.Resolve<IPresenter<ILEDView>>().View);
        }
    }
}
