using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicsProject_3_Core.Domain;

public class Asset
{
    public int Id { get; set; }
    
    [Name(nameof(SellDate))]
    public DateTime SellDate { get; set; }
    
    [Name(nameof(Name))]
    public string Name { get; set; }

    [Name(nameof(AssetCode))]
    public string AssetCode /*= Guid.NewGuid().ToString();*/{ get; set; }

    [Name(nameof(Price))]
    public decimal Price { get; set; }
    
    [Name(nameof(ShopAddress))]
    public string ShopAddress { get; set; }

    [Name(nameof(Count))]
    public decimal Count { get; set; }

    [Name(nameof(CostPrice))]
    public decimal CostPrice { get; set; }

    public decimal TotalOrderAmount => Price * Count;
}
