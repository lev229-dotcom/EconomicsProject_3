using EconomicsProject_3_Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicsProject_3_Core.Formuls;

public class Formulas
{
    public decimal GetPriceElasticityOfDemand(Asset firstAsset, Asset secondAsset)
    {
        decimal elasticity = (secondAsset.Count - firstAsset.Count) / firstAsset.Count
            / ((secondAsset.Price - firstAsset.Price) / firstAsset.Price);

        return Math.Round(elasticity, 3);
    }

    public decimal GetElasticityOfPriceOffer(Asset firstAsset, Asset secondAsset)
    {
        decimal elasticity = (secondAsset.Count - firstAsset.Count) / (secondAsset.Price - firstAsset.Price)
            * (firstAsset.Price / firstAsset.Count);

        return Math.Round(elasticity, 3);
    }
}
