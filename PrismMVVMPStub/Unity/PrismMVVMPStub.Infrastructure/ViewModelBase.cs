using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.ViewModel;

namespace PrismMVVMPStub.Infrastructure
{
    public class ViewModelBase : NotificationObject
    {
        /// <summary>
        /// This property is a hack to keep the presenter alive by making it referenced by ViewModel
        /// </summary>
        public object KeepAlive { get; set; }
    }
}
