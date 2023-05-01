using Caliburn.Micro;
using RetailManagerDesktopUI.Helpers;
using RetailManagerDesktopUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailManagerDesktopUI.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string _username;
        private string _password;
        private IAPIHelper _apiHelper;

        public LoginViewModel(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public string Username
        {
            get { return _username; } 
            set 
            {
                _username = value;
                NotifyOfPropertyChange(() => Username);
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
            }
        }

        public bool CanLogIn
        {
            get
            {

                if (Username?.Length > 0 && Password?.Length > 0)
                {
                    return true;
                }

                return false;
            }

        }

        public async Task LogIn()
        {
            try
            {
                var result = _apiHelper.AuthenticateAsync(Username, Password);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
