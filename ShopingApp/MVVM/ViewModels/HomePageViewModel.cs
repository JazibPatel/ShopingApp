using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ShopingApp.MVVM.Models;
using ShopingApp.MVVM.View;

namespace ShopingApp.MVVM.ViewModels
{
    internal class HomePageViewModel
    {
        public List<Product> Products { get; set; }

        public ICommand LoginBtn { get; }

        public ICommand SearchBtn { get; }

        public ICommand ProductPageBtn { get; }

        public HomePageViewModel()
        {
            Products = new List<Product>()
            {
                // Men Category (1-10)
                new Product
                {
                    Id = 1,
                    ImageUrl = "m1",
                    Name = "Slim Fit Denim Jacket",
                    Price = 1999.00F,
                    Category = "Man",
                },
                new Product
                {
                    Id = 2,
                    ImageUrl = "m2",
                    Name = "Casual Striped Shirt",
                    Price = 1299.00F,
                    Category = "Man",
                },
                new Product
                {
                    Id = 3,
                    ImageUrl = "m3",
                    Name = "Classic Polo T-shirt",
                    Price = 999.00F,
                    Category = "Man",
                },
                new Product
                {
                    Id = 4,
                    ImageUrl = "m4",
                    Name = "Regular Fit Chinos",
                    Price = 1799.00F,
                    Category = "Man",
                },
                new Product
                {
                    Id = 5,
                    ImageUrl = "m5",
                    Name = "Leather Biker Jacket",
                    Price = 3499.00F,
                    Category = "Man",
                },
                new Product
                {
                    Id = 6,
                    ImageUrl = "m6",
                    Name = "Hooded Sweatshirt",
                    Price = 1499.00F,
                    Category = "Man",
                },
                new Product
                {
                    Id = 7,
                    ImageUrl = "m7",
                    Name = "Stretch Skinny Jeans",
                    Price = 2299.00F,
                    Category = "Man",
                },
                new Product
                {
                    Id = 8,
                    ImageUrl = "m8",
                    Name = "Sports Joggers",
                    Price = 1899.00F,
                    Category = "Man",
                },
                new Product
                {
                    Id = 9,
                    ImageUrl = "m9",
                    Name = "Checked Formal Shirt",
                    Price = 1599.00F,
                    Category = "Man",
                },
                new Product
                {
                    Id = 10,
                    ImageUrl = "m10",
                    Name = "Cargo Utility Pants",
                    Price = 1999.00F,
                    Category = "Man",
                },
                // Women Category (11-20)
                new Product
                {
                    Id = 11,
                    ImageUrl = "w11",
                    Name = "Floral Print Maxi Dress",
                    Price = 2599.00F,
                    Category = "Women",
                },
                new Product
                {
                    Id = 12,
                    ImageUrl = "w12",
                    Name = "High Waist Jeans",
                    Price = 1799.00F,
                    Category = "Women",
                },
                new Product
                {
                    Id = 13,
                    ImageUrl = "w13",
                    Name = "Off Shoulder Top",
                    Price = 999.00F,
                    Category = "Women",
                },
                new Product
                {
                    Id = 14,
                    ImageUrl = "w14",
                    Name = "Formal Blazer",
                    Price = 2999.00F,
                    Category = "Women",
                },
                new Product
                {
                    Id = 15,
                    ImageUrl = "w15",
                    Name = "Casual Loose Jumpsuit",
                    Price = 1999.00F,
                    Category = "Women",
                },
                new Product
                {
                    Id = 16,
                    ImageUrl = "w16",
                    Name = "Pleated Skirt",
                    Price = 1599.00F,
                    Category = "Women",
                },
                new Product
                {
                    Id = 17,
                    ImageUrl = "w17",
                    Name = "Faux Leather Leggings",
                    Price = 1499.00F,
                    Category = "Women",
                },
                new Product
                {
                    Id = 18,
                    ImageUrl = "w18",
                    Name = "Top Puff Sleeves",
                    Price = 1299.00F,
                    Category = "Women",
                },
                new Product
                {
                    Id = 19,
                    ImageUrl = "w19",
                    Name = "Turtleneck Sweater",
                    Price = 1899.00F,
                    Category = "Women",
                },
                new Product
                {
                    Id = 20,
                    ImageUrl = "w20",
                    Name = "Classic Trench Coat",
                    Price = 3999.00F,
                    Category = "Women",
                },
                // Kids Category (21-30)
                new Product
                {
                    Id = 21,
                    ImageUrl = "k21",
                    Name = "Cartoon Print Hoodie",
                    Price = 899.00F,
                    Category = "Kid",
                },
                new Product
                {
                    Id = 22,
                    ImageUrl = "k22",
                    Name = "Soft Cotton Overalls",
                    Price = 1299.00F,
                    Category = "Kid",
                },
                new Product
                {
                    Id = 23,
                    ImageUrl = "k23",
                    Name = "Dinosaur Graphic T-shirt",
                    Price = 699.00F,
                    Category = "Kid",
                },
                new Product
                {
                    Id = 24,
                    ImageUrl = "k24",
                    Name = "Elastic Waist Jeans",
                    Price = 1099.00F,
                    Category = "Kid",
                },
                new Product
                {
                    Id = 25,
                    ImageUrl = "k25",
                    Name = "Polka Dot Dress",
                    Price = 1399.00F,
                    Category = "Kid",
                },
                new Product
                {
                    Id = 26,
                    ImageUrl = "k26",
                    Name = "Warm Fleece Jacket",
                    Price = 1599.00F,
                    Category = "Kid",
                },
                new Product
                {
                    Id = 27,
                    ImageUrl = "k27",
                    Name = "Denim Dungarees",
                    Price = 1799.00F,
                    Category = "Kid",
                },
                new Product
                {
                    Id = 28,
                    ImageUrl = "k28",
                    Name = "Cotton Pajama Set",
                    Price = 999.00F,
                    Category = "Kid",
                },
                new Product
                {
                    Id = 29,
                    ImageUrl = "k29",
                    Name = "Striped Cotton Romper",
                    Price = 1199.00F,
                    Category = "Kid",
                },
                new Product
                {
                    Id = 30,
                    ImageUrl = "k30",
                    Name = "Soft Knit Beanie",
                    Price = 599.00F,
                    Category = "Kid",
                },
            };

            LoginBtn = new Command(OpenLoginPage);
            SearchBtn = new Command(NavbarSearchPage);
            ProductPageBtn = new Command(OpenProductPage);

            
        }



        private void OpenLoginPage()
        {
            Application.Current.MainPage.Navigation.PushAsync(new LoginPage());
        }

        private void NavbarSearchPage()
        {
            Application.Current.MainPage.Navigation.PushAsync(new SearchPage());
        }

        private void OpenProductPage()
        {
            Application.Current.MainPage.Navigation.PushAsync(new ProductPage());
        }
    }
}
