using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrismMVVMPStub.Infrastructure;
using Microsoft.Practices.Prism.Regions;
using PrismMVVMPStub.SampleModule.Sample;
using System.ComponentModel.Composition.Hosting;
using Microsoft.Practices.Prism.MefExtensions.Modularity;
using System.ComponentModel.Composition;
using Microsoft.Practices.ServiceLocation;

namespace PrismMVVMPStub.SampleModule
{
    [ModuleExport(typeof(SampleModule))]
    public class SampleModule: ModuleBase
    {
        [ImportingConstructor]
        public SampleModule(IServiceLocator container, IRegionViewRegistry regionRegistry): base(container, regionRegistry)
        {

        }

        protected override void InitializeModule()
        {
            base.InitializeModule();

            RegionRegistry.RegisterViewWithRegion(RegionNames.SampleRegion, () => Container.GetInstance<IPresenter<ISampleView>>().View);

            Container.GetInstance<SampleController>().Run();
        }
    }
}
