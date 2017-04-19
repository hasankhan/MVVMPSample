using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoPrismMVVMPSample
{
    class MainWindowPresenter
    {
        MainWindowViewModel viewModel;
        
        public IMainWindow View { get; private set; }

        public MainWindowPresenter(IMainWindow view)
        {
            this.View = view;
            this.viewModel = new MainWindowViewModel();
            this.viewModel.KeepAlive = this;
            this.viewModel.ClickCommand = new DelegateCommand(ClickCommand_Execute, _=>true);

            View.DataContext = viewModel;
        }

        void ClickCommand_Execute(object args)
        {
            viewModel.Message = "Hello, World";
        }
    }
}
