using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrismMVVMPSample.Infrastructure;
using Microsoft.Practices.Prism.Events;
using PrismMVVMPSample.Infrastructure.Model;
using System.ComponentModel.Composition;

namespace PrismMVVMPSample.LEDModule.LED
{
    [Export(typeof(IPresenter<ILEDView>))]
    class LEDPresenter: PresenterBase<ILEDView, LEDViewModel>
    {
        [ImportingConstructor]
        public LEDPresenter(ILEDView view, IEventAggregator eventAggregator): base(view)
        {
            eventAggregator.GetEvent<ResultChangedEvent>().Subscribe(OnResultChanged);
        }

        void OnResultChanged(int result)
        {
            ViewModel.Result = result;
        }
    }
}
