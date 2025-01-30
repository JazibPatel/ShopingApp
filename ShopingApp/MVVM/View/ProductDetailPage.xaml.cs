
using ShopingApp.MVVM.Models;
using ShopingApp.MVVM.ViewModels;

namespace ShopingApp.MVVM.View;

public partial class ProductDetailPage : ContentPage
{
    public int count = 1;
    public ProductDetailPage(Product selectedProduct)
    {
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        BindingContext = selectedProduct;
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Application.Current.MainPage.Navigation.PopAsync();
    }

    private void DescriptionBtn(object sender, EventArgs e)
    {
        if (count == 1)
        {
            DescriptionGrid.IsVisible = true;
           
            count = 0;
        }
        else
        {
            DescriptionGrid.IsVisible = false;
            
            count = 1;
        }
    }

}
