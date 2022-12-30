using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.AspNetCore.Identity;

namespace API.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(StoreContext context, UserManager<User> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new User { UserName = "Sam", Email = "sam@test.com" };

                await userManager.CreateAsync(user, "Pa$$w0rd");
                await userManager.AddToRoleAsync(user, "Member");

                var admin = new User { UserName = "admin", Email = "admin@test.com" };

                await userManager.CreateAsync(admin, "Pa$$w0rd");
                await userManager.AddToRolesAsync(admin, new[] { "Member", "Admin" });
            }

            if (context.Products.Any())
                return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Single-Rotor",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 80000,
                    PictureUrl = "/images/products/img-1.jpg",
                    Brand = "Iceberg",
                    Type = "Syrax",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Fixed-Wing",
                    Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Price = 45000,
                    PictureUrl = "/images/products/img-2.jpg",
                    Brand = "Terra",
                    Type = "King",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Multi-Rotor",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 68000,
                    PictureUrl = "/images/products/img-3.jpg",
                    Brand = "Ventus",
                    Type = "Tiamat",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Fixed-Wing Hybrid",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 70000,
                    PictureUrl = "/images/products/img-4.jpg",
                    Brand = "Glace",
                    Type = "Dragon",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Small Drone",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 30000,
                    PictureUrl = "/images/products/img-5.jpg",
                    Brand = "Ventus",
                    Type = "Smaug",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Micro Drone",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 52000,
                    PictureUrl = "/images/products/img-6.jpg",
                    Brand = "Glace",
                    Type = "King",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Tactical Drone",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 20000,
                    PictureUrl = "/images/products/img-7.jpg",
                    Brand = "Terra",
                    Type = "Shenron",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Reconnaissance",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 80000,
                    PictureUrl = "/images/products/img-8.jpg",
                    Brand = "Ignis",
                    Type = "Smaug",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Large Combat",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 104500,
                    PictureUrl = "/images/products/img-9.jpg",
                    Brand = "Terra",
                    Type = "Tiamat",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Non-Combat Large",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 15900,
                    PictureUrl = "/images/products/img-10.jpg",
                    Brand = "Ventus",
                    Type = "Shenron",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Target and Decoy",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 17500,
                    PictureUrl = "/images/products/img-11.jpg",
                    Brand = "Iceberg",
                    Type = "Dragon",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "GPS Drone",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 28600,
                    PictureUrl = "/images/products/img-12.jpg",
                    Brand = "Ignis",
                    Type = "Tiamat",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Photography Drone",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 95500,
                    PictureUrl = "/images/products/img-13.jpg",
                    Brand = "Ventus",
                    Type = "Syrax",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Racing Drone",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 25000,
                    PictureUrl = "/images/products/img-14.jpg",
                    Brand = "Terra",
                    Type = "Smaug",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Dronemotion",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 19500,
                    PictureUrl = "/images/products/img-15.jpg",
                    Brand = "Glace",
                    Type = "Tiamat",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Drone Mini",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 24500,
                    PictureUrl = "/images/products/img-16.jpg",
                    Brand = "Iceberg",
                    Type = "Syrax",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Lite Drone",
                    Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                    Price = 45000,
                    PictureUrl = "/images/products/img-17.jpg",
                    Brand = "Ignis",
                    Type = "Smaug",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Inspire DRN",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/img-18.jpg",
                    Brand = "Ventus",
                    Type = "Dragon",
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
