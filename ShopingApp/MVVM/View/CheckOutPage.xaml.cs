using System.Diagnostics;
using ShopingApp.MVVM.Models;

namespace ShopingApp.MVVM.View;

public partial class CheckOutPage : ContentPage
{
    public CheckOutPage()
    {
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        BindingContext = CheckOutList.checkouts;
        updateToatl();
    }

    private void RemoveProduct(object sender, EventArgs e)
    {
        var removeproductbtn = (ImageButton)sender;
        var selectProduct = removeproductbtn.BindingContext as CheckOut;

        if (selectProduct == null || selectProduct.Product == null)
        {
            Debug.WriteLine("Selected product is null!");
            return;
        }

        var selectItem = selectProduct.Product;

        var ProductId = CheckOutList.checkouts.FirstOrDefault(p => p.Product.Id == selectItem.Id);

        if (ProductId != null)
        {
            CheckOutList.checkouts.Remove(ProductId);
            updateToatl();
        }
    }

    public void updateToatl()
    {
        var firstItem = CheckOutList.checkouts.FirstOrDefault();
        if (firstItem != null)
        {
            var Total = CheckOutList.checkouts.Sum(p => p.Price);
            total.Text = Total > 0 ? Total.ToString("F2") : "00.00";

        }
    }

    private async void OrderPlaced(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OrderPage());
        CheckOutList.checkouts.Clear();
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        CheckOutList.checkouts.Clear();
    }
}
