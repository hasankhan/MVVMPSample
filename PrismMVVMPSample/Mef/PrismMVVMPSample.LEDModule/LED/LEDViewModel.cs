using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrismMVVMPSample.Infrastructure;

namespace PrismMVVMPSample.LEDModule.LED
{
    class LEDViewModel: ViewModelBase
    {
        int result;
        public int Result
        {
            get { return result; }
            set
            {
                result = value;
                RaisePropertyChanged(() => Result);
            }
        }
    }
}
