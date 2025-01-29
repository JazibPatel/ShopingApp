using ShopingApp.MVVM.Models;
using ShopingApp.MVVM.ViewModels;
namespace ShopingApp.MVVM.View;

public partial class ProductPage : ContentPage
{
	public ProductPage(string category)
	{
		InitializeComponent();
		NavigationPage.SetHasNavigationBar(this, false);
		BindingContext = new ProductPageViewModel(category);

    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {

		await Application.Current.MainPage.Navigation.PushAsync(new ProductDetailPage());

    }

    private async void BackBtn(object sender, EventArgs e)
    {
        await Application.Current.MainPage.Navigation.PushAsync(new HomePage());

    }
}