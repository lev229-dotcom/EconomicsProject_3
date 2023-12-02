using EconomicsProject_3_Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicsProject_3_Core.Data;

public class DataContext : DbContext
{
    public DbSet<Asset> Assets { get; set; }
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        //Database.SetConnectionString("Server=LAPTOP-3SOVKD2O;Database=EcoProj;Trusted_Connection=True;"); 
        //Database.EnsureDeleted();
        //Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var id = Guid.NewGuid().ToString();
        modelBuilder.Entity<Asset>().HasKey(x => x.Id);

        modelBuilder.Entity<Asset>()
    .HasData(
    new Asset { Id = 1, SellDate = DateTime.UtcNow, Name = "Пряники", Price = 350, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = id },
    new Asset { Id = 2, SellDate = DateTime.UtcNow, Name = "Масло сливочное", Price = 250, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = Guid.NewGuid().ToString() },
    new Asset { Id = 3, SellDate = DateTime.UtcNow, Name = "Творог", Price = 450, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = Guid.NewGuid().ToString() },
    new Asset { Id = 4, SellDate = DateTime.UtcNow, Name = "Сыр", Price = 500, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = Guid.NewGuid().ToString() },
    
    new Asset { Id = 5, SellDate = DateTime.UtcNow, Name = "Пряники", Price = 320, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 300, AssetCode = id },
    new Asset { Id = 6, SellDate = DateTime.UtcNow, Name = "Пряники", Price = 320, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 300, AssetCode = id },
    new Asset { Id = 7, SellDate = DateTime.UtcNow, Name = "Пряники", Price = 320, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 300, AssetCode = id },
    new Asset { Id = 8, SellDate = DateTime.UtcNow, Name = "Пряники", Price = 320, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 300, AssetCode = id },
    new Asset { Id = 9, SellDate = DateTime.UtcNow, Name = "Пряники", Price = 320, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 300, AssetCode = id },
    new Asset { Id = 10, SellDate = DateTime.UtcNow, Name = "Пряники", Price = 320, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 300, AssetCode = id },
    new Asset { Id = 11, SellDate = DateTime.UtcNow, Name = "Пряники", Price = 320, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 300, AssetCode = id },
    new Asset { Id = 12, SellDate = DateTime.UtcNow, Name = "Пряники", Price = 320, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 300, AssetCode = id },
    new Asset { Id = 13, SellDate = DateTime.UtcNow, Name = "Пряники", Price = 320, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 300, AssetCode = id },
    new Asset { Id = 14, SellDate = DateTime.UtcNow, Name = "Пряники", Price = 320, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 300, AssetCode = id },
    new Asset { Id = 15, SellDate = DateTime.UtcNow, Name = "Пряники", Price = 320, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 300, AssetCode = id },
    new Asset { Id = 16, SellDate = DateTime.UtcNow, Name = "Пряники", Price = 320, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 300, AssetCode = id },
    new Asset { Id = 17, SellDate = DateTime.UtcNow, Name = "Пряники", Price = 320, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 300, AssetCode = id },
    new Asset { Id = 18, SellDate = DateTime.UtcNow, Name = "Пряники", Price = 320, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 300, AssetCode = id },
    new Asset { Id = 19, SellDate = DateTime.UtcNow, Name = "Пряники", Price = 320, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 300, AssetCode = id },
    new Asset { Id = 20, SellDate = DateTime.UtcNow, Name = "Пряники", Price = 320, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 300, AssetCode = id },
    new Asset { Id = 21, SellDate = DateTime.UtcNow, Name = "Пряники", Price = 320, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 300, AssetCode = id },
    new Asset { Id = 22, SellDate = DateTime.UtcNow, Name = "Пряники", Price = 320, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 300, AssetCode = id },
    new Asset { Id = 23, SellDate = DateTime.UtcNow, Name = "Пряники", Price = 320, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 300, AssetCode = id },
    new Asset { Id = 24, SellDate = DateTime.UtcNow, Name = "Пряники", Price = 320, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 300, AssetCode = id },
    new Asset { Id = 25, SellDate = DateTime.UtcNow, Name = "Пряники", Price = 320, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 300, AssetCode = id },
    new Asset { Id = 26, SellDate = DateTime.UtcNow, Name = "Пряники", Price = 320, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 300, AssetCode = id },
    
    new Asset { Id = 27, SellDate = DateTime.UtcNow.AddDays(-20), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 28, SellDate = DateTime.UtcNow.AddDays(-20), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 29, SellDate = DateTime.UtcNow.AddDays(-20), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 30, SellDate = DateTime.UtcNow.AddDays(-20), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 31, SellDate = DateTime.UtcNow.AddDays(-20), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 32, SellDate = DateTime.UtcNow.AddDays(-20), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 33, SellDate = DateTime.UtcNow.AddDays(-20), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 34, SellDate = DateTime.UtcNow.AddDays(-20), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 35, SellDate = DateTime.UtcNow.AddDays(-20), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 36, SellDate = DateTime.UtcNow.AddDays(-20), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 37, SellDate = DateTime.UtcNow.AddDays(-20), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 38, SellDate = DateTime.UtcNow.AddDays(-20), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 39, SellDate = DateTime.UtcNow.AddDays(-20), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 40, SellDate = DateTime.UtcNow.AddDays(-20), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 41, SellDate = DateTime.UtcNow.AddDays(-20), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 42, SellDate = DateTime.UtcNow.AddDays(-20), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 43, SellDate = DateTime.UtcNow.AddDays(-20), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 44, SellDate = DateTime.UtcNow.AddDays(-20), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 45, SellDate = DateTime.UtcNow.AddDays(-20), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 46, SellDate = DateTime.UtcNow.AddDays(-20), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 47, SellDate = DateTime.UtcNow.AddDays(-20), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 48, SellDate = DateTime.UtcNow.AddDays(-20), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id }
    );


    }
}
