using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.ComponentModel;

namespace NoPrismMVVMPSample
{
    class MainWindowViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public object KeepAlive { get; set; }
        public ICommand ClickCommand { get; set; }

        string message;
        public string Message
        {
            get { return message; }
            set 
            { 
                message = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Message"));
            }
        }
    }
}
