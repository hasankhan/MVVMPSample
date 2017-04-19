using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrismMVVMPStub.Infrastructure;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.Regions;
using PrismMVVMPStub.SampleModule.Sample;

namespace PrismMVVMPStub.SampleModule
{
    public class SampleModule: ModuleBase
    {
        public SampleModule(IUnityContainer container, IRegionViewRegistry regionRegistry): base(container, regionRegistry)
        {

        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            Container.RegisterType<ISampleView, SampleView>();
            Container.RegisterType<IPresenter<ISampleView>, SamplePresenter>();

            Container.RegisterType<SampleController>(new ContainerControlledLifetimeManager());
        }

        protected override void InitializeModule()
        {
            base.InitializeModule();

            RegionRegistry.RegisterViewWithRegion(RegionNames.SampleRegion, () => Container.Resolve<IPresenter<ISampleView>>().View);

            Container.Resolve<SampleController>().Run();
        }
    }
}
