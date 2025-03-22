using ShopingApp.MVVM.Models;
using ShopingApp.MVVM.ViewModels;
using System.Diagnostics;
namespace ShopingApp.MVVM.View;

public partial class ProductPage : ContentPage
{
    private string category;

    public ProductPage(string category, bool isSearch)
	{
		InitializeComponent();
		NavigationPage.SetHasNavigationBar(this, false);
		BindingContext = new ProductPageViewModel(category, isSearch);

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

    private void SortPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (SortPicker.SelectedIndex == -1) return;

        string selectedSort = SortPicker.SelectedItem.ToString();
        var sortedList = ((List<Product>)FilteredProductsView.ItemsSource);

        switch (selectedSort)
        {
            case "Price: Low to High":
                FilteredProductsView.ItemsSource = sortedList.OrderBy(p => p.Price).ToList();
                break;

            case "Price: High to Low":
                FilteredProductsView.ItemsSource = sortedList.OrderByDescending(p => p.Price).ToList();
                break;

            case "Name: A to Z":
                FilteredProductsView.ItemsSource = sortedList.OrderBy(p => p.Name).ToList();
                break;

            case "Name: Z to A":
                FilteredProductsView.ItemsSource = sortedList.OrderByDescending(p => p.Name).ToList();
                break;
        }
    }


}