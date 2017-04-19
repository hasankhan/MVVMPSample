using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismMVVMPSample.Infrastructure
{
    public interface IView
    {
        object DataContext {get; set;}
    }
}
