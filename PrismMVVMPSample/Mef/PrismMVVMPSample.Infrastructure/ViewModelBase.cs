using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Microsoft.Practices.Prism.ViewModel;

namespace PrismMVVMPSample.Infrastructure
{
    public class ViewModelBase: NotificationObject
    {
        /// <summary>
        /// This property is a hack to keep the presenter alive by making it referenced by ViewModel
        /// </summary>
        public object KeepAlive { get; set; }
    }
}
