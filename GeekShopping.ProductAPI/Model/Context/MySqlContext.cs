using Microsoft.EntityFrameworkCore;
using static System.Net.WebRequestMethods;

namespace GeekShopping.ProductAPI.Model.Context;

public class MySqlContext : DbContext
{
    public MySqlContext() { }
    public MySqlContext(DbContextOptions <MySqlContext>options): base(options) { }
    public DbSet<Product> Products { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        const string IMG_URL_BASE = "https://github.com/ivanclay/GeekShopping/blob/main/images/";

        modelBuilder.Entity<Product>().HasData(
            new Product 
            {
                Id = 1,
                Name = "Super Mario Cup",
                Price = new decimal(39.90),
                CategoryName = "Cup",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa non erat fringilla accumsan.",
                ImageUrl = $"{IMG_URL_BASE}1_super_mario.jpg"
            }
        );
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 2,
                Name = "T-Shirt No Internet",
                Price = new decimal(49.90),
                CategoryName = "T-Shirt",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa non erat fringilla accumsan.",
                ImageUrl = $"{IMG_URL_BASE}2_no_internet.jpg"
            }
        );
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 3,
                Name = "Vader Lamp",
                Price = new decimal(139.90),
                CategoryName = "Lamp",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa non erat fringilla accumsan.",
                ImageUrl = $"{IMG_URL_BASE}3_vader.jpg"
            }
        );
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 4,
                Name = "Storm Tropper",
                Price = new decimal(339.90),
                CategoryName = "Collection",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa non erat fringilla accumsan.",
                ImageUrl = $"{IMG_URL_BASE}4_storm_tropper.jpg"
            }
        );
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 5,
                Name = "100% Gamer",
                Price = new decimal(39.90),
                CategoryName = "T-Shirt",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa non erat fringilla accumsan.",
                ImageUrl = $"{IMG_URL_BASE}5_100_gamer.jpg"
            }
        );
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 6,
                Name = "SpaceX",
                Price = new decimal(39.90),
                CategoryName = "T-Shirt",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa non erat fringilla accumsan.",
                ImageUrl = $"{IMG_URL_BASE}6_spacex.jpg"
            }
        );
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 7,
                Name = "Coffee",
                Price = new decimal(39.90),
                CategoryName = "T-Shirt",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa non erat fringilla accumsan.",
                ImageUrl = $"{IMG_URL_BASE}7_coffee.jpg"
            }
        );
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 8,
                Name = "Cobra Kay",
                Price = new decimal(99.90),
                CategoryName = "T-Shirt",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa non erat fringilla accumsan.",
                ImageUrl = $"{IMG_URL_BASE}8_moletom_cobra_kay.jpg"
            }
        );
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 9,
                Name = "Star Talk",
                Price = new decimal(59.90),
                CategoryName = "Book",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa non erat fringilla accumsan.",
                ImageUrl = $"{IMG_URL_BASE}9_neil.jpg"
            }
        );
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 10,
                Name = "Millenium Falcon",
                Price = new decimal(539.90),
                CategoryName = "Play",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa non erat fringilla accumsan.",
                ImageUrl = $"{IMG_URL_BASE}10_milennium_falcon.jpg"
            }
        );
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 11,
                Name = "Mars",
                Price = new decimal(39.90),
                CategoryName = "T-Shirt",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa non erat fringilla accumsan.",
                ImageUrl = $"{IMG_URL_BASE}11_mars.jpg"
            }
        );
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 12,
                Name = "GNU LINUX",
                Price = new decimal(39.90),
                CategoryName = "T-Shirt",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa non erat fringilla accumsan.",
                ImageUrl = $"{IMG_URL_BASE}12_gnu_linux.jpg"
            }
        );
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 13,
                Name = "Dragon Ball",
                Price = new decimal(39.90),
                CategoryName = "T-Shirt",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa non erat fringilla accumsan.",
                ImageUrl = $"{IMG_URL_BASE}13_dragon_ball.jpg"
            }
        );
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 14,
                Name = "NASA",
                Price = new decimal(19.90),
                CategoryName = "Patch",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut et massa non erat fringilla accumsan.",
                ImageUrl = $"{IMG_URL_BASE}14_patch_nasa.jpg"
            }
        );
    }
}
