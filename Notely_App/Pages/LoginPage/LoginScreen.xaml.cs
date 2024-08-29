using Microsoft.Maui.Controls;
#if ANDROID
using Android.App;
using Android.Views.InputMethods;
using Android.Content;
#endif


namespace Notely_App.Pages.LoginPage;

public partial class LoginScreen : ContentPage
{
	LoginScreenVM _loginScreenVM;
	public LoginScreen()
	{
		try
		{
            InitializeComponent();
            BindingContext = _loginScreenVM = new LoginScreenVM();
        }
		catch (Exception ex)
		{

		}
		
	}

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		try
		{
			HideKeyBoard();
		}
		catch (Exception ex)
		{

		}
    }

    private void HideKeyBoard()
    {
		try
		{
#if ANDROID
			var activity = (Activity?)Microsoft.Maui.ApplicationModel.Platform.CurrentActivity;
            var inputMethodManager = (InputMethodManager?)activity?.GetSystemService(Context.InputMethodService);
            if (activity?.CurrentFocus != null)
            {
                inputMethodManager?.HideSoftInputFromWindow(activity.CurrentFocus.WindowToken, HideSoftInputFlags.None);

            }
#endif
        }
        catch (Exception)
		{

		}
    }
}