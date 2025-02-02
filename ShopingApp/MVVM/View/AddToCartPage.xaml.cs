using ShopingApp.MVVM.Models;
using System.Diagnostics;

namespace ShopingApp.MVVM.View;

public partial class AddToCartPage : ContentPage
{
    public AddToCartPage()
    {
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);

        BindingContext = CartList.Carts;

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
            var quantity = existingItem.Quantity += 1;
            var price = (double)existingItem.Product.Price * quantity;
            existingItem.TotalPrice = price;

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
                var quantity = existingItem.Quantity -= 1;
                var price = (double)existingItem.Product.Price * quantity;
                existingItem.TotalPrice = price;

                await Navigation.PushAsync(new AddToCartPage());
                Navigation.RemovePage(this);
            }
        }

    }
}