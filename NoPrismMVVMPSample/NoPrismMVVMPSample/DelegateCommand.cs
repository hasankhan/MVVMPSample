using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace NoPrismMVVMPSample
{
    class DelegateCommand : ICommand
    {
        Action<object> onExecute;
        Func<object, bool> canExecute;

        public event EventHandler CanExecuteChanged = delegate { };

        public DelegateCommand(Action<object> onExecute, Func<object, bool> canExecute)
        {
            this.onExecute = onExecute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return this.canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            this.onExecute(parameter);
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }
    }
}
