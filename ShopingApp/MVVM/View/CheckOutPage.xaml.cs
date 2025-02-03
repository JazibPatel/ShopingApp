namespace ShopingApp.MVVM.View;

public partial class CheckOutPage : ContentPage
{
	public CheckOutPage()
	{
		InitializeComponent();
		NavigationPage.SetHasNavigationBar(this, false);
		BindingContext = CheckOutList.checkouts;
	}
}