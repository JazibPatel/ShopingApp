using ShopingApp.MVVM.ViewModels;

namespace ShopingApp.MVVM.View;

public partial class HomePage : ContentPage
{

    public int count = 1;
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

    private void HomePageCategory(object sender, EventArgs e)
    {
        if (count == 1)
        {
            CategoryDropdownMenu.IsVisible = true;
            CategoryDropdown.Source = "minus.png";
            count = 0;
        }
        else
        {
            CategoryDropdownMenu.IsVisible = false;
            CategoryDropdown.Source = "plus.png";
            count = 1;
        }

    }
}