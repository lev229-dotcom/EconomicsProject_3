using System;
using System.Collections.Generic;
using System.Linq;
using EconomicsProject_3_Core.Domain;
using EconomicsProject_3_Core.Formuls;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Radzen;
using System.Text;
using System.Threading.Tasks;

namespace EconomicsProject_3_Front.Pages;


public partial class ElasticMaprazor
{
    DateTime startDateAsset1;
    DateTime endDateAsset1;
    DateTime startDateAsset2;
    DateTime endDateAsset2;
    string heatMapAndCalculations;
    int firstquantity;
    int firstprice;
    int secondquantity;
    int secondprice;
    int thirdquantity;
    int thirdprice;
    string firstAssetId;
    string secondAssetId;
    IEnumerable<Asset> assets;
    [Inject] DataContextService dataContextService { get; set; }
    [Inject] DialogService dialogService { get; set; }

    protected override async Task OnInitializedAsync()
    {
        //var query = await dataContextService.GetDataContext().Assets.ToListAsync();
        //var query1 = query.GroupBy(x => x.AssetCode)
        //      .Where(g => g.Count() > 1)
        //      .SelectMany(_ => _)
        //      .ToList();
        //var query2 = query.GroupBy(x => x.AssetCode)
        //      .Where(g => g.Count() == 1)
        //      .SelectMany(_ => _)
        //      .ToList();
        assets = await dataContextService.GetDataContext().Assets
            .GroupBy(_ => _.AssetCode)
            .Select(_ => _.OrderBy(a => a.AssetCode).First()).ToListAsync();


    }

    async Task CheckElasticMap()
    {
        var firstAssetsStats = await dataContextService
            .GetDataContext()
            .Assets
            .Where(_ => _.SellDate.Date >= startDateAsset1.Date && _.SellDate.Date <= endDateAsset1.Date && _.AssetCode == firstAssetId).ToListAsync();
        var count1 = firstAssetsStats.Sum(_ => _.Count);
        var price1 = firstAssetsStats.Average(_ => _.Price);

        var secondAssetsStats = await dataContextService
            .GetDataContext()
            .Assets
            .Where(_ => _.SellDate.Date >= startDateAsset2.Date && _.SellDate.Date <= endDateAsset2.Date && _.AssetCode == secondAssetId).ToListAsync();
        var count2 = secondAssetsStats.Sum(_ => _.Count);
        var price2 = secondAssetsStats.Average(_ => _.Price);

        var formulas = new Formulas();
        var elastic = formulas.GetPriceElasticityOfDemand(
            new Asset() { Price = price1, Count = count1 }, 
            new Asset() { Price = price2, Count = count2});
        
        
        
        
        
        string message;
        var sb = new StringBuilder();
        
        
        
        
        sb.AppendLine("<div>Резултат расчета эластичности");
        sb.Append("<br/>");
        sb.Append("<br/>");
        sb.AppendLine($"Количество продаж за первый период: {Math.Round(count1, 0)}");
        sb.AppendLine($"Выручка за первый период: {Math.Round(firstAssetsStats.Sum(_ => _.Count * _.Price), 0)}₽");
        sb.Append("<br/>");
        sb.Append("<br/>");
        sb.AppendLine($"Количество продаж за второй период: {Math.Round(count2)}");
        sb.AppendLine($"Выручка за второй период: {Math.Round(secondAssetsStats.Sum(_ => _.Count * _.Price), 0)}₽");
        sb.Append("<br/>");
        sb.Append("<br/>");
        sb.Append($"Эластичность = {Math.Abs(elastic)}");
        sb.Append("<br/>");
        sb.Append("<br/>");
        sb.Append("</div>");

        List<decimal> heatmapValues = new List<decimal>();

        List<int> heatmapHeaders = new List<int> { firstquantity, secondquantity, thirdquantity };

        List<int> heatmapLeftHeaders = new List<int> { firstprice, secondprice, thirdprice };

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                heatmapValues.Add(Math.Round((price2 - heatmapLeftHeaders[i]) / (count2 - heatmapHeaders[j]),2));
            }
        }
        
        sb.Append(GetHeatmapCells(elastic, heatmapValues, heatmapHeaders, heatmapLeftHeaders));
                

        heatMapAndCalculations = sb.ToString();

    }
}
