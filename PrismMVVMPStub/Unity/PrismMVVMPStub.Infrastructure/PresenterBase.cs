using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismMVVMPStub.Infrastructure
{
    public class PresenterBase<TView, TViewModel> : IPresenter<TView>
        where TView : IView
        where TViewModel : ViewModelBase, new()
    {
        public TViewModel ViewModel { get; set; }
        public TView View { get; private set; }

        public PresenterBase(TView view)
        {
            this.View = view;
            this.ViewModel = new TViewModel();
            this.ViewModel.KeepAlive = this;
            this.View.DataContext = ViewModel;
        }
    }
}
