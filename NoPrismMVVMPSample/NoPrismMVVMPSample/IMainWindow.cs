using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoPrismMVVMPSample
{
    interface IMainWindow
    {
        object DataContext { get; set; }
        void Show();
    }
}
