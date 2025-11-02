using EcommerceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());

            // Check if database has data
            if (context.Products.Any())
            {
                return; // Database already seeded
            }

            var products = new Product[]
            {
                new Product
                {
                    Name = "Wireless Noise-Cancelling Headphones",
                    Description = "Premium over-ear headphones with active noise cancellation, 30-hour battery life, and superior sound quality.",
                    Price = 299.99M,
                    Category = "Electronics",
                    ImageUrl = "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?w=500",
                    Stock = 45,
                    Rating = 4.7,
                    ReviewCount = 1284,
                    IsActive = true
                },
                new Product
                {
                    Name = "Smart Fitness Watch",
                    Description = "Track your workouts, heart rate, sleep patterns, and receive notifications. Water-resistant with 7-day battery.",
                    Price = 249.99M,
                    Category = "Electronics",
                    ImageUrl = "https://images.unsplash.com/photo-1523275335684-37898b6baf30?w=500",
                    Stock = 78,
                    Rating = 4.5,
                    ReviewCount = 892,
                    IsActive = true
                },
                new Product
                {
                    Name = "Minimalist Leather Backpack",
                    Description = "Handcrafted genuine leather backpack with laptop compartment. Perfect blend of style and functionality.",
                    Price = 189.99M,
                    Category = "Fashion",
                    ImageUrl = "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=500",
                    Stock = 32,
                    Rating = 4.8,
                    ReviewCount = 456,
                    IsActive = true
                },
                new Product
                {
                    Name = "Organic Cotton T-Shirt Pack",
                    Description = "Set of 3 premium organic cotton t-shirts. Soft, breathable, and eco-friendly. Available in multiple colors.",
                    Price = 59.99M,
                    Category = "Fashion",
                    ImageUrl = "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?w=500",
                    Stock = 120,
                    Rating = 4.6,
                    ReviewCount = 2103,
                    IsActive = true
                },
                new Product
                {
                    Name = "Stainless Steel Water Bottle",
                    Description = "Insulated 32oz water bottle keeps drinks cold for 24 hours or hot for 12 hours. BPA-free and durable.",
                    Price = 34.99M,
                    Category = "Home",
                    ImageUrl = "https://images.unsplash.com/photo-1602143407151-7111542de6e8?w=500",
                    Stock = 200,
                    Rating = 4.9,
                    ReviewCount = 3421,
                    IsActive = true
                },
                new Product
                {
                    Name = "Yoga Mat Pro",
                    Description = "Extra thick 6mm yoga mat with non-slip surface. Includes carrying strap. Perfect for yoga, pilates, and stretching.",
                    Price = 49.99M,
                    Category = "Sports",
                    ImageUrl = "https://images.unsplash.com/photo-1601925260368-ae2f83cf8b7f?w=500",
                    Stock = 85,
                    Rating = 4.4,
                    ReviewCount = 678,
                    IsActive = true
                },
                new Product
                {
                    Name = "Portable Bluetooth Speaker",
                    Description = "Waterproof speaker with 360° sound, 20-hour battery, and deep bass. Perfect for outdoor adventures.",
                    Price = 79.99M,
                    Category = "Electronics",
                    ImageUrl = "https://images.unsplash.com/photo-1608043152269-423dbba4e7e1?w=500",
                    Stock = 65,
                    Rating = 4.6,
                    ReviewCount = 1547,
                    IsActive = true
                },
                new Product
                {
                    Name = "Ceramic Coffee Mug Set",
                    Description = "Set of 4 handmade ceramic mugs. Microwave and dishwasher safe. Each mug holds 12oz.",
                    Price = 44.99M,
                    Category = "Home",
                    ImageUrl = "https://images.unsplash.com/photo-1514228742587-6b1558fcca3d?w=500",
                    Stock = 150,
                    Rating = 4.7,
                    ReviewCount = 934,
                    IsActive = true
                },
                new Product
                {
                    Name = "Running Shoes Ultra",
                    Description = "Lightweight running shoes with responsive cushioning and breathable mesh. Designed for marathon performance.",
                    Price = 159.99M,
                    Category = "Sports",
                    ImageUrl = "https://images.unsplash.com/photo-1542291026-7eec264c27ff?w=500",
                    Stock = 55,
                    Rating = 4.8,
                    ReviewCount = 2876,
                    IsActive = true
                },
                new Product
                {
                    Name = "Plant-Based Protein Powder",
                    Description = "30 servings of organic plant-based protein with all essential amino acids. Chocolate flavor, no artificial sweeteners.",
                    Price = 39.99M,
                    Category = "Health",
                    ImageUrl = "https://images.unsplash.com/photo-1579722821273-0f6c7d44362f?w=500",
                    Stock = 95,
                    Rating = 4.5,
                    ReviewCount = 1234,
                    IsActive = true
                },
                new Product
                {
                    Name = "Desk Organizer Set",
                    Description = "Bamboo desk organizer with multiple compartments for pens, papers, and accessories. Eco-friendly and stylish.",
                    Price = 29.99M,
                    Category = "Home",
                    ImageUrl = "https://images.unsplash.com/photo-1611269154421-4e27233ac5c7?w=500",
                    Stock = 110,
                    Rating = 4.3,
                    ReviewCount = 456,
                    IsActive = true
                },
                new Product
                {
                    Name = "Wireless Charging Pad",
                    Description = "Fast wireless charger compatible with all Qi-enabled devices. Sleek design with LED indicator.",
                    Price = 24.99M,
                    Category = "Electronics",
                    ImageUrl = "https://images.unsplash.com/photo-1591290619762-c588f0c2c999?w=500",
                    Stock = 140,
                    Rating = 4.4,
                    ReviewCount = 789,
                    IsActive = true
                }
            };

            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}