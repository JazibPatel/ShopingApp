using System.Diagnostics;
using ShopingApp.MVVM.Models;

namespace ShopingApp.MVVM.View;

public partial class AddToCartPage : ContentPage
{
    public AddToCartPage()
    {
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);

        BindingContext = CartList.Carts;

        var OrderValue = CartList.Carts.Sum(c => c.TotalPrice);

        orderValue.Text = OrderValue.ToString();

        if (OrderValue > 1999)
        {
            deliverCharges.Text = "149";
            var calc = (double)(OrderValue + 149.00);
            total.Text = calc.ToString();
        }
        else
        {
            deliverCharges.Text = "00";
            var calc = (double)(OrderValue);
            total.Text = calc.ToString();
        }
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Application.Current.MainPage.Navigation.PopAsync();
    }

    private async void BackBtn(object sender, EventArgs e)
    {
        await Application.Current.MainPage.Navigation.PopAsync();
    }

    private async void RemoveItem(object sender, EventArgs e)
    {
        var deleteBtn = (ImageButton)sender;
        var selectedCart = deleteBtn.BindingContext as Cart;

        if (selectedCart == null || selectedCart.Product == null)
        {
            Debug.WriteLine("Selected cart or product is null!");
            return;
        }

        var selectItem = selectedCart.Product;

        var existingItem = CartList.Carts.FirstOrDefault(i => i.Product.Id == selectItem.Id);

        if (existingItem != null)
        {
            CartList.Carts.Remove(existingItem);

            Debug.WriteLine($"Item removed: {selectItem.Id}");
            await Navigation.PushAsync(new AddToCartPage());
            Navigation.RemovePage(this);
        }
    }

    private async void AddQuantity(object sender, EventArgs e)
    {
        var AddBtn = (ImageButton)sender;
        var selectedCart = AddBtn.BindingContext as Cart;

        if (selectedCart == null || selectedCart.Product == null)
        {
            Debug.WriteLine("Selected cart or product is null!");
            return;
        }

        var selectItem = selectedCart.Product;

        var existingItem = CartList.Carts.FirstOrDefault(i => i.Product.Id == selectItem.Id);

        if (existingItem != null)
        {
            existingItem.Quantity += 1;
            existingItem.TotalPrice = existingItem.Quantity * (double)existingItem.Product.Price;

            await Navigation.PushAsync(new AddToCartPage());
            Navigation.RemovePage(this);
        }
    }

    private async void MinusQuantity(object sender, EventArgs e)
    {
        var MinusBtn = (ImageButton)sender;
        var selectedCart = MinusBtn.BindingContext as Cart;

        if (selectedCart == null || selectedCart.Product == null)
        {
            Debug.WriteLine("Selected cart or product is null!");
            return;
        }

        var selectItem = selectedCart.Product;

        var existingItem = CartList.Carts.FirstOrDefault(i => i.Product.Id == selectItem.Id);

        if (existingItem != null)
        {
            if (existingItem.Quantity > 1)
            {
                existingItem.Quantity -= 1;
                existingItem.TotalPrice =
                    existingItem.Quantity * (double)existingItem.Product.Price;

                await Navigation.PushAsync(new AddToCartPage());
                Navigation.RemovePage(this);
            }
        }
    }

    private void CheckOutBtn(object sender, EventArgs e)
    {
        foreach (var i in CartList.Carts)
        {
            
            Debug.WriteLine(
                $" All Product : {CartList.Carts.Count} \n " +
                $"Product Id : {i.Product.Id} \n " +
                $"Product qty : {i.Quantity} \n " +
                $"Product TPrice : {i.TotalPrice}"
            );

            CheckOutList.checkouts
        }
    }
}
