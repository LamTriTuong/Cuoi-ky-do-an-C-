using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Entities;

namespace ShopOnline.Api.Data
{
	public class ShopOnlineDbContext : DbContext
	{
		public ShopOnlineDbContext(DbContextOptions<ShopOnlineDbContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			//Products
			//Beauty Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 1,
				Name = "Balo Challenger",
				Description = "Phan thuong game thu top 100 td",
				ImageURL = "/photos/Balo/TD.jpg",
				Price = 350,
				Qty = 100,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 2,
				Name = "Balo Fpx",
				Description = "Balo of FPX Team",
				ImageURL = "/photos/Balo/FPX.jpg",
				Price = 400,
				Qty = 45,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 3,
				Name = "Balo IG ",
				Description = "Balo of IvitusGaming",
				ImageURL = "/photos/Balo/IG.jpg",
				Price = 450,
				Qty = 30,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 4,
				Name = "Balo T1",
				Description = "Balo of SKTelecomT1",
				ImageURL = "/photos/Balo/T1.jpg",
				Price = 350,
				Qty = 60,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 5,
				Name = "Balo TSM",
				Description = "Balo of TeamSoloMid",
				ImageURL = "/photos/Balo/TSM.jpg",
				Qty = 400,
				CategoryId = 1

			});
			//Electronics Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 6,
				Name = "Jacket DW",
				Description = "The jacket for Damwon Gaming",
				ImageURL = "/photos/Jacket/dw.jpg",
				Price = 700,
				Qty = 120,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 7,
				Name = "EDG Jacket",
				Description = "The Jacket for EdwardGaming Team",
				ImageURL = "/photos/Jacket/edg.jpg",
				Price = 800,
				Qty = 200,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 8,
				Name = "G2 Jacket",
				Description = "The jacket for the match of G2 team",
				ImageURL = "/photos/Jacket/g2.jpg",
				Price = 650,
				Qty = 300,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 9,
				Name = "GenG Jacket",
				Description = "The jacket for GenG team - The Team 1st of Korea",
				ImageURL = "/photos/Jacket/geng.jpg",
				Price = 600,
				Qty = 20,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 10,
				Name = "Fnc Jacket",
				Description = "It the Best",
				ImageURL = "/photos/Jacket/fnc.jpg",
				Price = 800,
				Qty = 15,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 11,
				Name = "Ahri suit",
				Description = "For Ahri Cosplayer",
				ImageURL = "/photos/suit/ahri.jpg",
				Price = 1500,
				Qty = 60,
				CategoryId = 3
			});
			//Furniture Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 12,
				Name = "Kda suit",
				Description = "For Cosplayer KDA",
				ImageURL = "/photos/suit/kda.jpg",
				Price = 1700,
				Qty = 212,
				CategoryId = 2
			});

			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 13,
				Name = "Leblanc Suit",
				Description = "Cosplay suit champ Leblanc",
				ImageURL = "/photos/suit/lb.jpg",
				Price = 2000,
				Qty = 112,
				CategoryId = 2
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 14,
				Name = "LuLu Suit",
				Description = "Very beautiful suit for cosplayer",
				ImageURL = "/photos/suit/lulu.jpg",
				Price = 1700,
				Qty = 90,
				CategoryId = 2
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 15,
				Name = "Neeko Suit",
				Description = "make u feel like real neeko",
				ImageURL = "/photos/suit/nekko.jpg",
				Price = 2100,
				Qty = 95,
				CategoryId = 2
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 16,
				Name = "TL T-Shirt",
				Description = "The T-Shirt of TeamLiquid for the match",
				ImageURL = "/photos/T-Shirt/tlts.jpg",
				Price = 150,
				Qty = 100,
				CategoryId = 2
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 17,
				Name = "C9 T-Shirt",
				Description = "The T-Shirt with logo of Could 9 Team",
				ImageURL = "/photos/T-Shirt/c9ts.jpg",
				Price = 200,
				Qty = 73,
				CategoryId = 2
			});
			//Shoes Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 18,
				Name = "FPX T-Shirt",
				Description = "The T-Shirt for fans of FPX Team",
				ImageURL = "/photos/T-Shirt/fxpts.jpg",
				Price = 250,
				Qty = 50,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 19,
				Name = "G2 Team T-shirt",
				Description = "T-Shirt Gamer of G2 Team using for match",
				ImageURL = "/photos/T-Shirt/g2ts.jpg",
				Price = 150,
				Qty = 60,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 20,
				Name = "GenG T-Shirt",
				Description = "GenG is the best team in Korea",
				ImageURL = "/photos/T-Shirt/gets.jpg",
				Price = 200,
				Qty = 70,
				CategoryId = 4
			});

			//Add users
			modelBuilder.Entity<User>().HasData(new User
			{
				Id = 1,
				UserName = "Tuong"

			});
			modelBuilder.Entity<User>().HasData(new User
			{
				Id = 2,
				UserName = "Tinh"

			});

			//Create Shopping Cart for Users
			modelBuilder.Entity<Cart>().HasData(new Cart
			{
				Id = 1,
				UserId = 1

			});
			modelBuilder.Entity<Cart>().HasData(new Cart
			{
				Id = 2,
				UserId = 2

			});
			//Add Product Categories
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 1,
				Name = "Balo",
				IconCSS = "fas fa-spa"
			});
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 2,
				Name = "Jacket",
				IconCSS = "fas fa-couch"
			});
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 3,
				Name = "suit",
				IconCSS = "fas fa-headphones"
			});
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 4,
				Name = "T-shirt",
				IconCSS = "fas fa-shoe-prints"
			});


		}

		public DbSet<Cart> Carts { get; set; }
		public DbSet<CartItem> CartItems { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ProductCategory> ProductCategories { get; set; }
		public DbSet<User> Users { get; set; }

	}
}