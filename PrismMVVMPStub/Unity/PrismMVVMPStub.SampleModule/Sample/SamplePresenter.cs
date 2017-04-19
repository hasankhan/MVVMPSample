using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrismMVVMPStub.Infrastructure;

namespace PrismMVVMPStub.SampleModule.Sample
{
    class SamplePresenter: PresenterBase<ISampleView, SampleViewModel>
    {
        public SamplePresenter(ISampleView view): base(view)
        {

        }
    }
}
