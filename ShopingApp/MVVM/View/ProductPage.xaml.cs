using ShopingApp.MVVM.ViewModels;
namespace ShopingApp.MVVM.View;

public partial class ProductPage : ContentPage
{
	public ProductPage()
	{
		InitializeComponent();
		NavigationPage.SetHasNavigationBar(this, false);
		BindingContext = new HomePageViewModel();
	}
}