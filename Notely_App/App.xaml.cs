using Notely_App.Pages.LoginPage;

namespace Notely_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginScreen();
        }
    }
}
