using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel.Composition;

namespace PrismMVVMPSample.LEDModule.LED
{
    /// <summary>
    /// Interaction logic for LEDView.xaml
    /// </summary>
    [Export(typeof(ILEDView))]
    public partial class LEDView : UserControl, ILEDView
    {
        public LEDView()
        {
            InitializeComponent();
        }
    }
}
