using System.Collections.Generic;
using System.Linq;
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any())
                return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Wave Ring",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 20000,
                    PictureUrl = "/images/products/img-1.jpg",
                    Brand = "Angular",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Braided Ring",
                    Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Price = 15000,
                    PictureUrl = "/images/products/img-2.jpg",
                    Brand = "Angular",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Snake Ring",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/img-3.jpg",
                    Brand = "NetCore",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pavé Diamond Dôme Ring",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 30000,
                    PictureUrl = "/images/products/img-4.jpg",
                    Brand = "NetCore",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Wishbone Stacker Set",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 25000,
                    PictureUrl = "/images/products/img-5.jpg",
                    Brand = "React",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Croissant Locket Necklace",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 12000,
                    PictureUrl = "/images/products/img-6.jpg",
                    Brand = "TypeScript",
                    Type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Beaded Gemstone Pendant",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1000,
                    PictureUrl = "/images/products/img-7.jpg",
                    Brand = "NetCore",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Heirloom Pendant",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 8000,
                    PictureUrl = "/images/products/img-8.jpg",
                    Brand = "React",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Birthstone Sphere Charm",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "/images/products/img-9.jpg",
                    Brand = "React",
                    Type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Marquise Topaz Earrings",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1800,
                    PictureUrl = "/images/products/img-10.jpg",
                    Brand = "VS Code",
                    Type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Emerald Gemstone Hoop",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "/images/products/img-11.jpg",
                    Brand = "VS Code",
                    Type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Gemstone Jacket Studs",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1600,
                    PictureUrl = "/images/products/img-12.jpg",
                    Brand = "React",
                    Type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Bold Pearl Huggies",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1400,
                    PictureUrl = "/images/products/img-13.jpg",
                    Brand = "React",
                    Type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Large Charlotte Hoops",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 25000,
                    PictureUrl = "/images/products/img-14.jpg",
                    Brand = "Redis",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Croissant Dôme Bracelet",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 18999,
                    PictureUrl = "/images/products/img-15.jpg",
                    Brand = "NetCore",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Organic Pearl Hoops",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 19999,
                    PictureUrl = "/images/products/img-16.jpg",
                    Brand = "NetCore",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Mini Lotus Studs",
                    Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                    Price = 15000,
                    PictureUrl = "/images/products/img-17.jpg",
                    Brand = "Angular",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Triple Marquise Studs",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/img-18.jpg",
                    Brand = "Angular",
                    Type = "Boots",
                    QuantityInStock = 100
                },
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}
