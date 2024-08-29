using Notely_App.Helpers.BaseViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Notely_App.Pages.LoginPage
{
    public class LoginScreenModel : BaseViewModel
    {
        public ICommand LoginCommand { get; set; }

        string? _Emailtext;

        public string Emailtext
        {
            get { return _Emailtext!; }
            set { SetProperty(ref _Emailtext, value); }
        }

        public Regex? EmailRegex { get; set; }

        string? _EmailErrortext;

        public string EmailErrortext
        {
            get { return _EmailErrortext!; }
            set { SetProperty(ref _EmailErrortext, value); }
        }

        bool _EmailErrorTextVisibility;

        public bool EmailErrorTextVisibility
        {
            get { return _EmailErrorTextVisibility; }
            set { SetProperty(ref _EmailErrorTextVisibility, value); }
        }
    }
}
