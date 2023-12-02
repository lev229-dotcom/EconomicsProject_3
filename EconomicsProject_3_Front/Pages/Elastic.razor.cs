using EconomicsProject_3_Core.Domain;
using EconomicsProject_3_Core.Formuls;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Radzen;
using System.Text;

namespace EconomicsProject_3_Front.Pages;

public partial class Elastic
{
    DateTime startDateAsset1;
    DateTime endDateAsset1;
    DateTime startDateAsset2;
    DateTime endDateAsset2;
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

    async Task CheckElastic()
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
        sb.AppendLine("Резултат расчета эластичности");
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
        sb.Append($"Эластичность = {elastic}");
        sb.Append("<br/>");
        sb.Append("<br/>");
        if (elastic < -1)
        {
            message = $"Спрос эластичен. <br/>При снижении цены на 1% спрос будет увеличивается на {Math.Abs(elastic)}%. ";
        }
        else if(elastic > 1)
        {
            message = $"Спрос эластичен. <br/>При изменении цены на 1% спрос будет уменьшается на {Math.Abs(elastic)}%. <br/>Для увеличения продаж необходимо понизить стоимость";
        }
        else
        {
            message = $"Спрос неэластичен. <br/>При изменении цены на 1% спрос будет изменяется на {Math.Abs(elastic)}%. <br/>Товар повседневного спроса или не имеющего замены. <br/>Для увеличения спроса необходимо понизить стоимость";
        }
        sb.Append(message);
        dialogService.Alert(sb.ToString(), "Итог", new AlertOptions() { OkButtonText = "Закрыть итог" });
    }
}
