using ShopingApp.MVVM.Models;
using ShopingApp.MVVM.ViewModels;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace ShopingApp.MVVM.View;

public partial class SearchPage : ContentPage
{
    public ObservableCollection<Product> FilteredProducts { get; set; } = new();
    private List<Product> ProductList { get; set; }
    public SearchPage(List<Product> productList)
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this,false);

        ProductList = productList;
        SearchProductList.ItemsSource = FilteredProducts;

        BindingContext = new SearchPageViewModel();
	}

    private void Searchbar_TextChanged(object sender, TextChangedEventArgs e)
    {
        string search = e.NewTextValue?.ToLower();

        // 🔹 Reset list if search is empty
        if (string.IsNullOrEmpty(search))
        {
            FilteredProducts.Clear();
            foreach (var item in ProductList)
            {
                FilteredProducts.Add(item);
            }
            return;
        }

        // 🔹 Filter products by name
        var filtered = ProductList.Where(p => p.Name.ToLower().Contains(search) || p.Category.ToLower().Contains(search)).ToList();

        FilteredProducts.Clear();
        foreach (var item in filtered)
        {
            FilteredProducts.Add(item);
        }
    }
    private async void SearchProductClick(object sender, EventArgs e)
    {

        Product selectedProduct = null;

        if (sender is ImageButton imageButton)
        {
            selectedProduct = imageButton.BindingContext as Product;
        }
        else if (sender is Label label)
        {
            selectedProduct = label.BindingContext as Product;
        }

        if (selectedProduct != null)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ProductDetailPage(selectedProduct));
        }
        else
        {
            Debug.WriteLine("Selected product is null or not of the correct type.");
        }

    }

    private async void Searchbar_SearchButtonPressed(object sender, EventArgs e)
    {

        string SearchQuery = Searchbar.Text?.Trim().ToLower();

        if (!string.IsNullOrWhiteSpace(SearchQuery)) {
            await Navigation.PushAsync(new ProductPage(SearchQuery, true));
        }

    }
}