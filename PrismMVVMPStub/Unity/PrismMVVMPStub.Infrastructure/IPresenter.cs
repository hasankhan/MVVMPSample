using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismMVVMPStub.Infrastructure
{
    public interface IPresenter<TView> where TView : IView
    {
        TView View { get; }
    }
}
