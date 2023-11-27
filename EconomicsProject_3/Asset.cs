using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicsProject_3;

public class Asset
{
    public string Name { get; set; }

    public decimal Price { get; set; }

    public decimal Count { get; set; }

    public AssetTypes AssetType { get; set; }
}
