using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrismMVVMPSample.Infrastructure;
using Microsoft.Practices.Prism.Regions;
using PrismMVVMPSample.KeypadModule.Keypad;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Prism.MefExtensions.Modularity;
using System.ComponentModel.Composition;

namespace PrismMVVMPSample.KeypadModule
{
    [ModuleExport(typeof(KeypadModule))]
    public class KeypadModule: ModuleBase
    {
        [ImportingConstructor]
        public KeypadModule(IServiceLocator container, IRegionViewRegistry regionRegistry): base(container, regionRegistry)
        {

        }

        protected override void InitializeModule()
        {
            base.InitializeModule();

            RegionRegistry.RegisterViewWithRegion(RegionNames.KeyPadRegion, () => Container.GetInstance<IPresenter<IKeypadView>>().View);
        }
    }
}
