using ShopingApp.MVVM.Models;
using ShopingApp.MVVM.ViewModels;
using System.Diagnostics;

namespace ShopingApp.MVVM.View;

public partial class ProductDetailPage : ContentPage
{
    public int count = 1;
    public int count1 = 1;
    public int count2 = 1;

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
            Description.TextColor = Colors.Red;
            DescriptionBtmImage.Source = "minus.png";

            count = 0;
        }
        else
        {
            DescriptionGrid.IsVisible = false;
            Description.TextColor = Colors.Black;
            DescriptionBtmImage.Source = "arrowdown.png";
            count = 1;
        }
    }

    private void MaterialsBtn(object sender, EventArgs e)
    {
        if (count1 == 1)
        {
            MaterialsGrid.IsVisible = true;
            Materials.TextColor = Colors.Red;
            MaterialsImage.Source = "minus.png";

            count1 = 0;
        }
        else
        {
            MaterialsGrid.IsVisible = false;
            Materials.TextColor = Colors.Black;
            MaterialsImage.Source = "arrowdown.png";
            count1 = 1;
        }
    }

    private void CareGuideBtn(object sender, EventArgs e)
    {
        if (count2 == 1)
        {
            CareGuideGrid.IsVisible = true;
            CareGuide.TextColor = Colors.Red;
            CareGuideImage.Source = "minus.png";

            count2 = 0;
        }
        else
        {
            CareGuideGrid.IsVisible = false;
            CareGuide.TextColor = Colors.Black;
            CareGuideImage.Source = "arrowdown.png";

            count2 = 1;
        }
    }

    private async void SizeGuideBtn(object sender, EventArgs e)
    {
        await Application.Current.MainPage.Navigation.PushAsync(new SizePage());
    }

    private async void AddToCart (object sender, EventArgs e)
    {
        var addButton = (Button)sender;
        var selectedProduct = addButton.BindingContext as Product;

        if (selectedProduct != null) {
            Debug.WriteLine($"Selected product: {selectedProduct.Name}");
            await Navigation.PushAsync(new AddToCartPage(selectedProduct));
        }
        else
        {
            Debug.WriteLine("Selected product is null or not of the correct type.");
        }
    }
}
