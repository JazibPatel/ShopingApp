using ShopingApp.MVVM.ViewModels;

namespace ShopingApp.MVVM.View;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		NavigationPage.SetHasNavigationBar(this, false);
		BindingContext = new LoginPageViewModel();
	}
}