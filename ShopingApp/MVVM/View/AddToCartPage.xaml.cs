using ShopingApp.MVVM.Models;

namespace ShopingApp.MVVM.View;

public partial class AddToCartPage : ContentPage
{
    public AddToCartPage()
    {
    }

    public AddToCartPage(Product product)
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        BindingContext = product;
	}

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Application.Current.MainPage.Navigation.PopAsync();
    }
}