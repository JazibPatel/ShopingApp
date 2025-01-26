using ShopingApp.MVVM.ViewModels;

namespace ShopingApp.MVVM.View;

public partial class SearchPage : ContentPage
{
	public SearchPage()
	{
		InitializeComponent();
		NavigationPage.SetHasNavigationBar(this, false);
		BindingContext = new SearchPageViewModel();
	}
}