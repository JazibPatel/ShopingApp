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

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        FlyoutNavbar.TranslationX = -FlyoutNavbar.Width;
        FlyoutNavbar.IsVisible = true;
        await FlyoutNavbar.TranslateTo(0, 0, 500, Easing.CubicOut);
    }

    private  async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
       await FlyoutNavbar.TranslateTo(-FlyoutNavbar.Width, 0, 500, Easing.CubicIn);
        FlyoutNavbar.IsVisible = false;
    }
}