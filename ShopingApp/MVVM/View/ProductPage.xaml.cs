using ShopingApp.MVVM.Models;
using ShopingApp.MVVM.ViewModels;
using System.Diagnostics;
namespace ShopingApp.MVVM.View;

public partial class ProductPage : ContentPage
{
	public ProductPage(string category)
	{
		InitializeComponent();
		NavigationPage.SetHasNavigationBar(this, false);
		BindingContext = new ProductPageViewModel(category);

    }

    // In ProductPage.xaml.cs
private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        // Get the selected product from the sender's BindingContext
        var imageButton = (ImageButton)sender;
        var selectedProduct = imageButton.BindingContext as Product;

        // Check if the cast was successful
        if (selectedProduct != null)
        {
            // Navigate to ProductDetailPage and pass the selected product
            await Application.Current.MainPage.Navigation.PushAsync(new ProductDetailPage(selectedProduct));
        }
        else
        {
            // Handle the case where casting failed
            Debug.WriteLine("Selected product is null or not of the correct type.");
        }
    }


    private async void BackBtn(object sender, EventArgs e)
    {
        await Application.Current.MainPage.Navigation.PopAsync();

    }
}