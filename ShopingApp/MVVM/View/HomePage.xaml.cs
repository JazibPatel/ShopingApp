using ShopingApp.MVVM.ViewModels;

namespace ShopingApp.MVVM.View;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		BindingContext = new HomePageViewModel();

    }
}