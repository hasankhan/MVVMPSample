using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrismMVVMPStub.Infrastructure;
using System.ComponentModel.Composition;

namespace PrismMVVMPStub.SampleModule
{
    [PartCreationPolicy(CreationPolicy.Shared)]
    [Export]
    class SampleController: IController
    {
        public void Run()
        {
        }
    }
}
