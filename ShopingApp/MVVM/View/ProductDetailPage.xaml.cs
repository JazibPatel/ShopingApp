
using ShopingApp.MVVM.Models;
using ShopingApp.MVVM.ViewModels;

namespace ShopingApp.MVVM.View;

public partial class ProductDetailPage : ContentPage
{
    public ProductDetailPage()
    {
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }
}
