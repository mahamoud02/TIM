using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using Caliburn.Micro;

namespace TIMDESKTOPUSERINTERFACE.ViewModels

{
    public class ShellViewModel  :Conductor<object>
    {
        private LoginViewModel _loginViewModel;

        public ShellViewModel (LoginViewModel lginVM)
        {
            _loginViewModel = lginVM;
            ActivateItem(_loginViewModel);
            
            
                

        }

     

    }
    //public Loginscreen()
    //{

    //}

}
