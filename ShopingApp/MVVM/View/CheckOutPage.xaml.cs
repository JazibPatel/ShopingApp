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
        if (
            string.IsNullOrWhiteSpace(firstname.Text)
            || string.IsNullOrWhiteSpace(lastname.Text)
            || string.IsNullOrWhiteSpace(phone.Text)
            || string.IsNullOrWhiteSpace(address.Text)
            || string.IsNullOrWhiteSpace(postelcode.Text)
            || string.IsNullOrWhiteSpace(email.Text)
            || string.IsNullOrWhiteSpace(city.Text)
        ) {
            await Application.Current.MainPage.DisplayAlert("Error", "Fill Complete Form", "ok");
            return;
        }

        foreach (var item in CheckOutList.checkouts)
        {
            var newOrder = new Order
            {
                Product = item.Product,
                TotalQuantity = item.Quantity,
                TotalPrice = (double)(item.Quantity * item.Product.Price),
                Pending = true,
                Shipped = false,
                Delivered = false,
            };

            OrderList.orders.Add(newOrder);
        }
        CheckOutList.checkouts.Clear();
        await Navigation.PushAsync(new OrderPage());
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        CheckOutList.checkouts.Clear();
    }
}
