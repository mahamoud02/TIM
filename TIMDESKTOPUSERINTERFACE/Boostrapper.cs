using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TIMDESKTOPUSERINTERFACE.ViewModels;

namespace TIMDESKTOPUSERINTERFACE
{
    public class Boostrapper : BootstrapperBase
    {
        public Boostrapper()
        {
            Initialize();
        }
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();

        }
    }
}
