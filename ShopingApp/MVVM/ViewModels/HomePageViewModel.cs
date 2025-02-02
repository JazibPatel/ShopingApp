using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public List<Product> ManProducts { get; set; }
        public List<Product> Products { get; set; }
        public ICommand LoginBtn { get; }
        public ICommand AddToCartBtn { get; }
        public ICommand CheckOutBtn { get; }
        public ICommand SearchBtn { get; }
        public ICommand ProductPageBtn { get; }
        public ICommand ManCategoryBtn { get; }
        public ICommand WomenCategoryBtn { get; }
        public ICommand KidCategoryBtn { get; }

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
                    Color = "Blue",
                    Description =
                        "This Slim Fit Denim Jacket offers a modern look with its tailored fit and durable denim material. Designed for comfort, this jacket is perfect for everyday wear. The classic blue color pairs well with a wide range of outfits, making it a versatile addition to your wardrobe. It features functional pockets and a button closure for a streamlined silhouette. A great choice for layering, it adds an effortlessly stylish touch to any casual outfit. Ideal for casual outings or evening wear, it is both practical and fashionable.",
                },
                new Product
                {
                    Id = 2,
                    ImageUrl = "m2",
                    Name = "Casual Striped Shirt",
                    Price = 1299.00F,
                    Category = "Man",
                    Color = "White/Blue Stripes",
                    Description =
                        "This Casual Striped Shirt combines a sleek, modern design with the classic appeal of stripes. The white and blue stripes add a refreshing look while maintaining an understated charm. Crafted from lightweight fabric, this shirt ensures comfort throughout the day. Perfect for both casual and semi-formal occasions, it can be paired with chinos or jeans. It offers a tailored fit that provides a polished look, while remaining breathable for warmer weather. A versatile piece for any man's wardrobe, it’s easy to style and always in fashion.",
                },
                new Product
                {
                    Id = 3,
                    ImageUrl = "m3",
                    Name = "Classic Polo T-shirt",
                    Price = 999.00F,
                    Category = "Man",
                    Color = "Black",
                    Description =
                        "This Classic Polo T-shirt is a timeless wardrobe essential, made from soft cotton for maximum comfort. The black color adds versatility and sophistication, making it suitable for both casual and semi-casual looks. The ribbed collar and three-button placket bring a touch of classic polo style. Its breathable fabric makes it ideal for warm days, while the classic cut provides a flattering fit. Whether paired with shorts, jeans, or chinos, this T-shirt adds an effortlessly cool vibe to any outfit. A perfect blend of style and comfort for any occasion.",
                },
                new Product
                {
                    Id = 4,
                    ImageUrl = "m4",
                    Name = "Regular Fit Chinos",
                    Price = 1799.00F,
                    Category = "Man",
                    Color = "Khaki",
                    Description =
                        "These Regular Fit Chinos in khaki are the perfect balance of style and comfort. The cotton blend fabric ensures durability while providing flexibility throughout the day. With a regular fit, these chinos offer a relaxed yet tailored look, suitable for both casual and business-casual outfits. The khaki color pairs well with a variety of shirts and jackets, making it an incredibly versatile piece. The chinos feature a zip fly and button closure for a streamlined finish. Great for work, weekend wear, or casual outings, these chinos are a must-have in your wardrobe.",
                },
                new Product
                {
                    Id = 5,
                    ImageUrl = "m5",
                    Name = "Leather Biker Jacket",
                    Price = 3499.00F,
                    Category = "Man",
                    Color = "Black",
                    Description =
                        "This Leather Biker Jacket offers a bold and rebellious style with premium leather craftsmanship. The black leather exterior is both sleek and durable, making it perfect for cooler weather and outdoor adventures. Designed with a slim fit, it features zippers, snap collars, and bold stitching that enhance its rugged, biker-inspired aesthetic. The inside lining provides a comfortable fit while maintaining breathability. Perfect for adding an edge to any casual or evening look, this jacket is designed to make a statement. Durable and stylish, it's an essential piece for any man's closet.",
                },
                new Product
                {
                    Id = 6,
                    ImageUrl = "m6",
                    Name = "Hooded Sweatshirt",
                    Price = 1499.00F,
                    Category = "Man",
                    Color = "Grey",
                    Description =
                        "This Hooded Sweatshirt combines comfort and style with its soft fleece lining and sleek grey color. The adjustable drawstring hood offers added warmth and protection from the elements. With a relaxed fit, this sweatshirt provides all-day comfort, whether worn for lounging or casual outings. The front kangaroo pocket adds functionality, allowing you to carry small essentials or keep your hands warm. The ribbed cuffs and hem ensure a snug fit, while the minimalist design allows for easy pairing with jeans or joggers. A versatile and cozy addition to your wardrobe, perfect for layering or wearing on its own.",
                },
                new Product
                {
                    Id = 7,
                    ImageUrl = "m7",
                    Name = "Stretch Skinny Jeans",
                    Price = 2299.00F,
                    Category = "Man",
                    Color = "Dark Blue",
                    Description =
                        "These Stretch Skinny Jeans in dark blue offer a sleek, contemporary fit with added stretch for comfort and mobility. The denim is soft yet durable, making these jeans a great choice for everyday wear. The skinny cut provides a modern, fashion-forward look while remaining comfortable. The dark blue color is versatile, easily paired with a variety of shirts and jackets. Ideal for both casual outings and nights out, these jeans offer both style and functionality. With a flattering fit, these jeans will quickly become a go-to in your wardrobe for versatile styling options.",
                },
                new Product
                {
                    Id = 8,
                    ImageUrl = "m8",
                    Name = "Sports Joggers",
                    Price = 1899.00F,
                    Category = "Man",
                    Color = "Black",
                    Description =
                        "These Sports Joggers in black combine athletic style with comfort. Made from a breathable cotton blend, they provide flexibility for any activity, whether you're hitting the gym or relaxing at home. The tapered fit offers a modern look, while the elastic waistband with drawstring ensures a secure and customizable fit. Featuring side pockets, these joggers offer both practicality and style, making them perfect for running errands or casual outings. The simple black color adds versatility, allowing them to pair effortlessly with your favorite T-shirts or hoodies.",
                },
                new Product
                {
                    Id = 9,
                    ImageUrl = "m9",
                    Name = "Checked Formal Shirt",
                    Price = 1599.00F,
                    Category = "Man",
                    Color = "Red/White Checkered",
                    Description =
                        "This Checked Formal Shirt features a bold red and white checkered pattern that adds a pop of color to your formal or business-casual wardrobe. Made from soft cotton, this shirt offers comfort and breathability throughout the day. The classic button-down collar and cuffs ensure a polished look, while the slim fit design offers a contemporary silhouette. Whether worn with dress pants for work or paired with jeans for a more casual setting, this shirt is versatile and stylish. A timeless piece that transitions seamlessly from work to evening outings, providing a sharp and clean appearance.",
                },
                new Product
                {
                    Id = 10,
                    ImageUrl = "m10",
                    Name = "Cargo Utility Pants",
                    Price = 1999.00F,
                    Category = "Man",
                    Color = "Olive Green",
                    Description =
                        "These Cargo Utility Pants in olive green offer a practical and stylish option for men who value both function and fashion. The cargo-style design features multiple pockets, making them perfect for carrying small essentials while on the go. Made from durable cotton, they are comfortable enough for all-day wear and tough enough for outdoor activities. The relaxed fit provides ample room for movement, while the olive green color gives them a rugged, utilitarian look. Whether worn for casual outings or outdoor adventures, these pants deliver both style and utility.",
                },
                // Women Category (11-20)
                new Product
                {
                    Id = 11,
                    ImageUrl = "w11",
                    Name = "Floral Print Maxi Dress",
                    Price = 2599.00F,
                    Category = "Women",
                    Color = "Pink/Floral",
                    Description =
                        "This Floral Print Maxi Dress exudes femininity and grace with its flowing silhouette and vibrant pink floral print. Made from lightweight fabric, it offers comfort and breathability, perfect for warmer weather. The empire waistline enhances the dress's flow, creating an elegant and flattering fit. With its sleeveless design and scoop neckline, it's ideal for summer parties, weddings, or casual outings. The dress effortlessly combines style and comfort, making it a versatile piece in any woman's wardrobe. Pair it with sandals for a laid-back look or dress it up with heels for more formal occasions.",
                },
                new Product
                {
                    Id = 12,
                    ImageUrl = "w12",
                    Name = "High Waist Jeans",
                    Price = 1799.00F,
                    Category = "Women",
                    Color = "Blue",
                    Description =
                        "These High Waist Jeans offer a flattering fit with their high-rise design, elongating the legs and enhancing your silhouette. The blue denim is soft yet durable, ensuring comfort throughout the day. With a slim fit, these jeans provide a modern, chic look that can easily transition from day to night. The high waist gives them a trendy, retro-inspired style, while the classic button closure and zip fly offer a secure fit. Perfect for pairing with crop tops, blouses, or jackets, these jeans offer both style and versatility for any occasion.",
                },
                new Product
                {
                    Id = 13,
                    ImageUrl = "w13",
                    Name = "V-Neck Blouse",
                    Price = 1499.00F,
                    Category = "Women",
                    Color = "White",
                    Description =
                        "This elegant V-neck blouse in white is the perfect addition to any wardrobe. Crafted from soft, breathable fabric, it offers comfort and style. The V-neckline adds a touch of sophistication, while the relaxed fit ensures ease of movement. Whether dressed up for a formal occasion or dressed down for a casual day out, this blouse provides versatility and timeless appeal. Pair it with jeans or a skirt for a chic, effortless look.",
                },
                new Product
                {
                    Id = 14,
                    ImageUrl = "w14",
                    Name = "A-Line Skirt",
                    Price = 1099.00F,
                    Category = "Women",
                    Color = "Black",
                    Description =
                        "This A-line skirt in black is a classic wardrobe staple. The flattering shape elongates the legs and provides a sleek silhouette. Made from comfortable fabric, it’s perfect for both professional and casual settings. Whether paired with a blouse for the office or a tee for a more relaxed look, this skirt offers endless styling possibilities. The simple yet elegant design makes it a versatile piece for year-round wear.",
                },
                new Product
                {
                    Id = 15,
                    ImageUrl = "w15",
                    Name = "Button-Up Cardigan",
                    Price = 1299.00F,
                    Category = "Women",
                    Color = "Gray",
                    Description =
                        "This cozy button-up cardigan in gray is perfect for layering over any outfit. Made from soft knit fabric, it provides warmth and comfort during cooler weather. The button-up closure and long sleeves add to its practicality, while the relaxed fit ensures a flattering look. Whether worn over a dress or paired with jeans, this cardigan is a versatile addition to your wardrobe.",
                },
                new Product
                {
                    Id = 16,
                    ImageUrl = "w16",
                    Name = "Pleated Midi Skirt",
                    Price = 1799.00F,
                    Category = "Women",
                    Color = "Navy Blue",
                    Description =
                        "This pleated midi skirt in navy blue combines elegance and movement. The pleated design adds texture and volume, while the midi length offers a timeless, flattering silhouette. Perfect for both casual and formal occasions, this skirt can be dressed up with a blouse or worn casually with a t-shirt. The lightweight fabric ensures comfort, making it a versatile piece for any season.",
                },
                new Product
                {
                    Id = 17,
                    ImageUrl = "w17",
                    Name = "Chunky Knit Sweater",
                    Price = 1999.00F,
                    Category = "Women",
                    Color = "Beige",
                    Description =
                        "This chunky knit sweater in beige offers ultimate warmth and style. The thick knit fabric provides a cozy fit, perfect for cooler weather. The relaxed, oversized design ensures comfort and a laid-back vibe. The ribbed details on the sleeves and hem add texture to the sweater. Pair it with jeans or leggings for a casual, chic look that’s perfect for autumn and winter.",
                },
                new Product
                {
                    Id = 18,
                    ImageUrl = "w18",
                    Name = "Pencil Skirt",
                    Price = 1299.00F,
                    Category = "Women",
                    Color = "Red",
                    Description =
                        "This sleek pencil skirt in red is the perfect piece for both the office and evening outings. The form-fitting design accentuates the curves while maintaining a professional look. The stretchy fabric ensures comfort and ease of movement, while the vibrant red color adds a pop of boldness to your wardrobe. Whether paired with a blouse for work or a crop top for a night out, this skirt is versatile and stylish.",
                },
                new Product
                {
                    Id = 19,
                    ImageUrl = "w19",
                    Name = "Off-Shoulder Top",
                    Price = 1599.00F,
                    Category = "Women",
                    Color = "Black",
                    Description =
                        "This off-shoulder top in black exudes effortless elegance. The relaxed fit and stretchy fabric offer comfort, while the off-shoulder design adds a touch of femininity. Perfect for warm-weather outings or casual evenings, this top pairs easily with jeans, skirts, or shorts. The versatile color ensures it can be paired with virtually any bottom, making it a must-have staple for your wardrobe.",
                },
                new Product
                {
                    Id = 20,
                    ImageUrl = "w20",
                    Name = "Leather Biker Jacket",
                    Price = 3599.00F,
                    Category = "Women",
                    Color = "Black",
                    Description =
                        "This edgy black leather biker jacket adds a rebellious flair to any outfit. Crafted from genuine leather, it offers both durability and style. The zip-up front, asymmetric collar, and metallic hardware create a bold, rocker-chic look. Whether worn over a dress for contrast or paired with jeans for an everyday look, this jacket is perfect for those who love to make a statement with their fashion choices.",
                },
                // Kids Category (21-30)
                new Product
                {
                    Id = 21,
                    ImageUrl = "k21",
                    Name = "Cartoon Print Hoodie",
                    Price = 899.00F,
                    Category = "Kid",
                    Color = "Yellow",
                    Description =
                        "This Cartoon Print Hoodie is a fun and cozy piece for kids who love vibrant colors and playful designs. Made from soft cotton, it keeps kids warm and comfortable during cooler days. The bright yellow color is cheerful and eye-catching, while the cute cartoon print adds an extra touch of fun. With a front pocket for convenience and a drawstring hood for added warmth, it's perfect for casual outings or lounging around at home. Easy to pair with jeans, leggings, or sweatpants, this hoodie is a stylish and playful addition to any child's wardrobe.",
                },
                new Product
                {
                    Id = 22,
                    ImageUrl = "k22",
                    Name = "Soft Cotton Overalls",
                    Price = 1299.00F,
                    Category = "Kid",
                    Color = "Light Blue",
                    Description =
                        "These Soft Cotton Overalls are designed for ultimate comfort and easy movement. The light blue color adds a fresh, bright touch, perfect for spring and summer. Made from soft cotton, they are gentle on the skin and breathable, making them ideal for all-day wear. The adjustable straps ensure a perfect fit, while the snap closures make them easy to put on and take off. Whether worn for playdates, casual outings, or family gatherings, these overalls offer both style and practicality. A must-have for any child's wardrobe, combining cuteness with comfort.",
                },
                new Product
                {
                    Id = 23,
                    ImageUrl = "k23",
                    Name = "Dinosaur Graphic T-shirt",
                    Price = 699.00F,
                    Category = "Kid",
                    Color = "Green",
                    Description =
                        "This Dinosaur Graphic T-shirt is perfect for kids who love adventure and prehistoric creatures. The green color and bold dinosaur graphic make it eye-catching and fun. Made from soft cotton, it ensures comfort and breathability throughout the day. The classic round neckline and short sleeves offer a relaxed fit, perfect for playtime or casual outings. Easy to pair with shorts, jeans, or leggings, this T-shirt adds a playful element to any child's wardrobe. A great gift for any young dinosaur enthusiast, combining fun and comfort in one stylish package.",
                },
                new Product
                {
                    Id = 24,
                    ImageUrl = "k24",
                    Name = "Elastic Waist Jeans",
                    Price = 1099.00F,
                    Category = "Kid",
                    Color = "Dark Blue",
                    Description =
                        "These comfy dark blue elastic waist jeans are perfect for your little one. With a soft cotton fabric and an easy pull-on design, they're ideal for everyday wear. The adjustable waistband ensures a secure fit while allowing for growth.",
                },
                new Product
                {
                    Id = 25,
                    ImageUrl = "k25",
                    Name = "Polka Dot Dress",
                    Price = 1399.00F,
                    Category = "Kid",
                    Color = "Red/White Polka Dots",
                    Description =
                        "This playful red and white polka dot dress adds a fun touch to any occasion. With its soft cotton fabric and twirl-worthy skirt, it’s a must-have for your child’s wardrobe. Perfect for casual outings or dressy events!",
                },
                new Product
                {
                    Id = 26,
                    ImageUrl = "k26",
                    Name = "Warm Fleece Jacket",
                    Price = 1599.00F,
                    Category = "Kid",
                    Color = "Purple",
                    Description =
                        "Keep your little one cozy and warm with this purple fleece jacket. Ideal for chilly weather, it features soft fleece material and a zip-up front for easy dressing. The bright color and comfortable fit make it a favorite for kids.",
                },
                new Product
                {
                    Id = 27,
                    ImageUrl = "k27",
                    Name = "Denim Dungarees",
                    Price = 1799.00F,
                    Category = "Kid",
                    Color = "Light Blue",
                    Description =
                        "These light blue denim dungarees combine comfort and style in one. Featuring adjustable straps and a relaxed fit, they are perfect for active kids. Whether for playdates or family outings, these dungarees offer versatility and durability.",
                },
                new Product
                {
                    Id = 28,
                    ImageUrl = "k28",
                    Name = "Cotton Pajama Set",
                    Price = 999.00F,
                    Category = "Kid",
                    Color = "Pink",
                    Description =
                        "This soft cotton pajama set in pink is perfect for a good night’s sleep. Made from breathable fabric, it ensures comfort throughout the night. The cute design and cozy feel make it a bedtime favorite for your little one.",
                },
                new Product
                {
                    Id = 29,
                    ImageUrl = "k29",
                    Name = "Striped Cotton Romper",
                    Price = 1199.00F,
                    Category = "Kid",
                    Color = "Blue/White Stripes",
                    Description =
                        "This striped cotton romper is both stylish and comfortable for your little one. The soft cotton material and easy snap closure make it perfect for playtime or naptime. The fun blue and white stripes add a classic touch.",
                },
                new Product
                {
                    Id = 30,
                    ImageUrl = "k30",
                    Name = "Soft Knit Beanie",
                    Price = 599.00F,
                    Category = "Kid",
                    Color = "Gray",
                    Description =
                        "This soft knit beanie in gray is the perfect accessory to keep your child warm during the colder months. The stretchy knit ensures a snug, comfortable fit, and its neutral color complements any outfit.",
                },
            };

            ManCategoryBtn = new Command(() => OpenProductPage("Man"));

            WomenCategoryBtn = new Command(() => OpenProductPage("Women"));

            KidCategoryBtn = new Command(() => OpenProductPage("Kid"));

            LoginBtn = new Command(OpenLoginPage);

            SearchBtn = new Command(NavbarSearchPage);

            AddToCartBtn = new Command(OpenAddToCartPage);

            CheckOutBtn = new Command(OpenCheckOutPage);

            //ProductPageBtn = new Command(OpenProductPage);

            ManProducts = Products.Where(p => p.Category == "Man").ToList();
        }

        private void OpenCheckOutPage()
        {
            Application.Current.MainPage.Navigation.PushAsync(new CheckOutPage());
        }
        private void OpenAddToCartPage()
        {
            Application.Current.MainPage.Navigation.PushAsync(new AddToCartPage());
        }
        private void OpenLoginPage()
        {
            Application.Current.MainPage.Navigation.PushAsync(new LoginPage());
        }

        private void NavbarSearchPage()
        {
            Application.Current.MainPage.Navigation.PushAsync(new SearchPage());
        }

        private void OpenProductPage(string category)
        {
            Application.Current.MainPage.Navigation.PushAsync(new ProductPage(category));
        }
    }
}
