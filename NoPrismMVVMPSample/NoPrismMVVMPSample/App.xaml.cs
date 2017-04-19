using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using Microsoft.Practices.Unity;

namespace NoPrismMVVMPSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            IUnityContainer container = new UnityContainer();
            RegisterTypes(container);
            var view = container.Resolve<MainWindowPresenter>().View;
            view.Show();
        }

        static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IMainWindow, MainWindow>();
        }
    }
}
