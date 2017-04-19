using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrismMVVMPSample.Infrastructure;
using System.Windows.Input;

namespace PrismMVVMPSample.KeypadModule.Keypad
{
    class KeypadViewModel: ViewModelBase
    {
        public ICommand KeyPressedCommand { get; set; }
        public ICommand OperatorCommand { get; set; }
    }
}
