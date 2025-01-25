using ShopingApp.MVVM.ViewModels;

namespace ShopingApp.MVVM.View;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        BindingContext = new HomePageViewModel();

    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        FlyoutNavbar.IsVisible = true;
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        FlyoutNavbar.IsVisible = false;
    }
}