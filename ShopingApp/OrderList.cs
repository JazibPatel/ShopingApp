using ShopingApp.MVVM.Models;
using System.Collections.ObjectModel;

public static class OrderList
{
    public static ObservableCollection<Order> orders { get; set; } = new ObservableCollection<Order>() {

        new Order
        {
            Product = new Product
            {
                Name = "Slim Fit Denim Jacket",
                Price = 1999.00F,
                ImageUrl = "m1.png",
                Color = "Blue"
            },
            TotalQuantity = 2,
            TotalPrice = 4998,
            Pending = true,
            Shipped = false,
            Delivered = false
        },

        new Order
        {
            Product = new Product
            {
                Name = "Classic Polo T-shirt",
                Price = 999.00F,
                ImageUrl = "m3.png",
                Color = "Black"
            },
            TotalQuantity = 1,
            TotalPrice = 999,
            Pending = true,
            Shipped = true,
            Delivered = false
        },
        new Order
        {
            Product = new Product
            {
                Name = "Hooded Sweatshirt",
                Price = 1499.00F,
                ImageUrl = "m6.png",
                Color = "Grey"
            },
            TotalQuantity = 1,
            TotalPrice = 1499,
            Pending = true,
            Shipped = true,
            Delivered = true
        }

    };
}
