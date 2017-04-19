using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrismMVVMPStub.Infrastructure;
using System.ComponentModel.Composition;

namespace PrismMVVMPStub.SampleModule.Sample
{
    [Export(typeof(IPresenter<ISampleView>))]
    class SamplePresenter: PresenterBase<ISampleView, SampleViewModel>
    {
        [ImportingConstructor]
        public SamplePresenter(ISampleView view): base(view)
        {

        }
    }
}
