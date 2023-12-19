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
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var id = Guid.NewGuid().ToString();
        var id2 = Guid.NewGuid().ToString();
        modelBuilder.Entity<Asset>().HasKey(x => x.Id);

        modelBuilder.Entity<Asset>()
    .HasData(
    new Asset { Id = 1, SellDate = DateTime.UtcNow, Name = "Пряники", Price = 350, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = id },
    new Asset { Id = 2, SellDate = DateTime.UtcNow, Name = "Масло сливочное", Price = 250, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = id2 },
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
    new Asset { Id = 48, SellDate = DateTime.UtcNow.AddDays(-20), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    
    
    new Asset { Id = 49, SellDate = DateTime.UtcNow.AddDays(-2), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 50, SellDate = DateTime.UtcNow.AddDays(-2), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 51, SellDate = DateTime.UtcNow.AddDays(-2), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 52, SellDate = DateTime.UtcNow.AddDays(-2), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 53, SellDate = DateTime.UtcNow.AddDays(-3), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 54, SellDate = DateTime.UtcNow.AddDays(-3), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 55, SellDate = DateTime.UtcNow.AddDays(-3), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 56, SellDate = DateTime.UtcNow.AddDays(-3), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 57, SellDate = DateTime.UtcNow.AddDays(-4), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 58, SellDate = DateTime.UtcNow.AddDays(-4), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 59, SellDate = DateTime.UtcNow.AddDays(-4), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 60, SellDate = DateTime.UtcNow.AddDays(-4), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 61, SellDate = DateTime.UtcNow.AddDays(-4), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 62, SellDate = DateTime.UtcNow.AddDays(-5), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 63, SellDate = DateTime.UtcNow.AddDays(-5), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 64, SellDate = DateTime.UtcNow.AddDays(-5), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 65, SellDate = DateTime.UtcNow.AddDays(-5), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 66, SellDate = DateTime.UtcNow.AddDays(-5), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 67, SellDate = DateTime.UtcNow.AddDays(-5), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 68, SellDate = DateTime.UtcNow.AddDays(-5), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 69, SellDate = DateTime.UtcNow.AddDays(-5), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 70, SellDate = DateTime.UtcNow.AddDays(-6), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    
    new Asset { Id = 71, SellDate = DateTime.UtcNow.AddDays(-6), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 72, SellDate = DateTime.UtcNow.AddDays(-6), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 73, SellDate = DateTime.UtcNow.AddDays(-6), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 74, SellDate = DateTime.UtcNow.AddDays(-6), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 75, SellDate = DateTime.UtcNow.AddDays(-6), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 76, SellDate = DateTime.UtcNow.AddDays(-6), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 77, SellDate = DateTime.UtcNow.AddDays(-6), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 78, SellDate = DateTime.UtcNow.AddDays(-6), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 79, SellDate = DateTime.UtcNow.AddDays(-6), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 80, SellDate = DateTime.UtcNow.AddDays(-6), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 81, SellDate = DateTime.UtcNow.AddDays(-6), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 82, SellDate = DateTime.UtcNow.AddDays(-6), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 83, SellDate = DateTime.UtcNow.AddDays(-6), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 84, SellDate = DateTime.UtcNow.AddDays(-6), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 85, SellDate = DateTime.UtcNow.AddDays(-7), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 86, SellDate = DateTime.UtcNow.AddDays(-7), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 87, SellDate = DateTime.UtcNow.AddDays(-7), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 88, SellDate = DateTime.UtcNow.AddDays(-7), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 89, SellDate = DateTime.UtcNow.AddDays(-8), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 90, SellDate = DateTime.UtcNow.AddDays(-8), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 91, SellDate = DateTime.UtcNow.AddDays(-8), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 92, SellDate = DateTime.UtcNow.AddDays(-8), Name = "Пряники", Price = 220, ShopAddress = "Тверская, 26", Count = 15, CostPrice = 300, AssetCode = id },
    new Asset { Id = 93, SellDate = DateTime.UtcNow, Name = "Масло сливочное", Price = 250, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = id2 },
    new Asset { Id = 94, SellDate = DateTime.UtcNow.AddDays(-1), Name = "Масло сливочное", Price = 250, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = id2 },
    new Asset { Id = 95, SellDate = DateTime.UtcNow.AddDays(-1), Name = "Масло сливочное", Price = 250, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = id2 },
    new Asset { Id = 96, SellDate = DateTime.UtcNow.AddDays(-1), Name = "Масло сливочное", Price = 250, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = id2 },
    new Asset { Id = 97, SellDate = DateTime.UtcNow.AddDays(-2), Name = "Масло сливочное", Price = 250, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = id2 },
    new Asset { Id = 98, SellDate = DateTime.UtcNow.AddDays(-2), Name = "Масло сливочное", Price = 250, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = id2 },
    new Asset { Id = 99, SellDate = DateTime.UtcNow.AddDays(-3), Name = "Масло сливочное", Price = 250, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = id2 },
    new Asset { Id = 100, SellDate = DateTime.UtcNow.AddDays(-4), Name = "Масло сливочное", Price = 250, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = id2 },
    new Asset { Id = 101, SellDate = DateTime.UtcNow.AddDays(-4), Name = "Масло сливочное", Price = 250, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = id2 },
    new Asset { Id = 102, SellDate = DateTime.UtcNow.AddDays(-4), Name = "Масло сливочное", Price = 250, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = id2 },
    new Asset { Id = 103, SellDate = DateTime.UtcNow.AddDays(-4), Name = "Масло сливочное", Price = 250, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = id2 },
    new Asset { Id = 104, SellDate = DateTime.UtcNow.AddDays(-4), Name = "Масло сливочное", Price = 250, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = id2 },
    
    new Asset { Id = 105, SellDate = DateTime.UtcNow.AddDays(-5), Name = "Масло сливочное", Price = 250, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = id2 },
    new Asset { Id = 106, SellDate = DateTime.UtcNow.AddDays(-5), Name = "Масло сливочное", Price = 250, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = id2 },
    new Asset { Id = 107, SellDate = DateTime.UtcNow.AddDays(-5), Name = "Масло сливочное", Price = 250, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = id2 },
    new Asset { Id = 108, SellDate = DateTime.UtcNow.AddDays(-5), Name = "Масло сливочное", Price = 250, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = id2 },
    new Asset { Id = 109, SellDate = DateTime.UtcNow.AddDays(-5), Name = "Масло сливочное", Price = 250, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = id2 },
    new Asset { Id = 110, SellDate = DateTime.UtcNow.AddDays(-5), Name = "Масло сливочное", Price = 250, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = id2 },
    new Asset { Id = 111, SellDate = DateTime.UtcNow.AddDays(-5), Name = "Масло сливочное", Price = 250, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = id2 },

    new Asset { Id = 112, SellDate = DateTime.UtcNow.AddDays(-5), Name = "Масло сливочное", Price = 250, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = id2 },
    new Asset { Id = 113, SellDate = DateTime.UtcNow.AddDays(-5), Name = "Масло сливочное", Price = 250, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = id2 },
    new Asset { Id = 114, SellDate = DateTime.UtcNow.AddDays(-5), Name = "Масло сливочное", Price = 250, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = id2 },
    new Asset { Id = 115, SellDate = DateTime.UtcNow.AddDays(-5), Name = "Масло сливочное", Price = 250, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = id2 },
    new Asset { Id = 116, SellDate = DateTime.UtcNow.AddDays(-5), Name = "Масло сливочное", Price = 250, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = id2 },
    new Asset { Id = 117, SellDate = DateTime.UtcNow.AddDays(-5), Name = "Масло сливочное", Price = 250, ShopAddress = "Тверская, 26", Count = 5, CostPrice = 320, AssetCode = id2 }

    );


    }
}
