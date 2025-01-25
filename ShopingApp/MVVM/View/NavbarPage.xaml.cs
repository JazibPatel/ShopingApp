using ShopingApp.MVVM.ViewModels;

namespace ShopingApp.MVVM.View;

public partial class NavbarPage : ContentPage
{
	public NavbarPage()
	{
		InitializeComponent();
		BindingContext = new NavbarPageViewModel();
	}
}