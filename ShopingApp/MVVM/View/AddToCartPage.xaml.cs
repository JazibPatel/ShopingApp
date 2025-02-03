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

    private async void CheckOutBtn(object sender, EventArgs e)
    {
        //foreach (var i in CartList.Carts)
        //{
        //    Debug.WriteLine(
        //        $" All Product : {CartList.Carts.Count} \n "
        //            + $"Product Id : {i.Product.Id} \n "
        //            + $"Product qty : {i.Quantity} \n "
        //            + $"Product TPrice : {i.TotalPrice}"
        //    );
        //}
        if (CartList.Carts.Count >= 1)
        {
            var total = CartList.Carts.Sum(c => c.TotalPrice);

            if (total > 1999)
            {
                total = (double)(total + 149.00);
            }

            foreach (var item in CartList.Carts)
            {
                CheckOutList.checkouts.Add(
                    new CheckOut
                    {
                        Product = item.Product,
                        Quantity = item.Quantity,
                        Price = item.Quantity * (double)item.Product.Price,
                        Total = total,
                        Pending = true,
                        InProcess = false,
                        Delivered = false,
                    }
                );
            }

            CartList.Carts.Clear();

            await Navigation.PushAsync(new CheckOutPage());
            Navigation.RemovePage(this);

            //foreach (var item in CheckOutList.checkouts)
            //{
            //    Debug.WriteLine(
            //        $"Product : {item.Product} \n "
            //            + $"Quantity : {item.Quantity} \n"
            //            + $" Price : {item.Price} \n "
            //            + $"Total : {item.Total} \n "
            //            + $"Pending : {item.Pending} \n"
            //            + $"InProcess : {item.InProcess} \n"
            //            + $"Delivered : {item.Delivered}"
            //    );
            //}
        }
        addproducttocart.IsVisible = true;
        await Task.Delay(1500);
        addproducttocart.IsVisible = false;
    }
}
