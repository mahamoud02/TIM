﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIMDESKTOPUSERINTERFACE.Helper;

namespace TIMDESKTOPUSERINTERFACE.ViewModels
{
    public class LoginViewModel:Screen
    {
        private string _username;
        private string _password;
        private IAPIHalper _apihalper;
        public LoginViewModel ( IAPIHalper  apihalper)
        {
            _apihalper = apihalper;
        }

        public string UserName
        {
            get { return _username; }
            set
            {
                _username = value;
                NotifyOfPropertyChange(() => UserName);
                NotifyOfPropertyChange(() => CanLogIn);
            }

        }
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                NotifyOfPropertyChange(() => Password);
               NotifyOfPropertyChange(() => CanLogIn);
               // Canlogin(Username, Password);

            }
        }
        public bool CanLogIn
        {
            get
            {
                bool output=false;

                if (UserName?.Length > 0 && Password?.Length > 0)
                {
                    output = true;
                    Console.WriteLine();

                }
                return output;
            }
        }
        public async Task LogIn()
        {
            try
            {
                var result = await _apihalper.Authenticate(UserName, Password);
            }
            catch (Exception ex )
            {

                Console.WriteLine(ex.Message);
            }
        }

    }
}
