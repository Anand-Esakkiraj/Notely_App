using Notely_App.Helpers.EmailValidatorClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Notely_App.Pages.LoginPage
{
    public class LoginScreenVM : LoginScreenModel
    {
        public LoginScreenVM() 
        {
			try
			{
                LoginCommand = new Command(onLoginButtonClicked);


                EmailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$",
					RegexOptions.Compiled | RegexOptions.IgnoreCase);
                EmailErrortext = string.Empty;
				EmailErrorTextVisibility = false;

            }
			catch (Exception ex)
			{

			}

        }

        private void onLoginButtonClicked()
        {
			try
			{
                EmailErrorTextVisibility = EmailValidationMethod();
			}
			catch (Exception ex)
			{

			}
        }

        private bool EmailValidationMethod()
        {
			try
			{
				if (!string.IsNullOrWhiteSpace(Emailtext))
				{
					if (EmailRegex!.IsMatch(Emailtext))
					{
                        return true;
                    }
					else
					{
						EmailErrortext = "Please enter an valid email address";
                        return false;
                    }
					
				}
				else
				{
					EmailErrortext = "Please enter an email address";
					return false;
				}
			}
			catch (Exception ex)
			{
				return false;
			}
        }
    }
}
