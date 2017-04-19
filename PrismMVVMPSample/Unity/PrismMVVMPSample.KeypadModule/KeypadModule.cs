using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrismMVVMPSample.Infrastructure;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.Regions;
using PrismMVVMPSample.KeypadModule.Keypad;

namespace PrismMVVMPSample.KeypadModule
{
    public class KeypadModule: ModuleBase
    {
        public KeypadModule(IUnityContainer container, IRegionViewRegistry regionRegistry): base(container, regionRegistry)
        {

        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            Container.RegisterType<IKeypadView, KeypadView>();
            Container.RegisterType<IPresenter<IKeypadView>, KeypadPresenter>();
        }

        protected override void InitializeModule()
        {
            base.InitializeModule();

            RegionRegistry.RegisterViewWithRegion(RegionNames.KeyPadRegion, () => Container.Resolve<IPresenter<IKeypadView>>().View);
        }
    }
}
