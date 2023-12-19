using EconomicsProject_3_Core.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace EconomicsProject_3_Front.Pages;

public partial class OrderStats
{
    [Inject] private DiagramService DiagramService { get; set; }
    [Inject] DataContextService dataContextService { get; set; }


    IEnumerable<DiagramServiceModel> orderForFirstDate;
    // IEnumerable<Order> orderForSecondDate;

    DateTime startDate { get; set; } = DateTime.Parse("01.12.2023");
    DateTime endDate { get; set; } = DateTime.Parse("12.12.2023");
    string firstAssetId;
    IEnumerable<Asset> assets;


    protected override async Task OnInitializedAsync()
    {
        base.OnInitialized();

        await Get();
        assets = await dataContextService.GetDataContext().Assets
            .GroupBy(_ => _.AssetCode).Select(_ => _.OrderBy(a => a.AssetCode).First())
            .ToListAsync();

    }

    public async Task Get()
    {
        orderForFirstDate = await DiagramService.GetOrdersByDate(startDate, endDate, firstAssetId);
        // orderForSecondDate = await DiagramService.GetOrdersByDate(endDate);
    }

    string FormatAsRub(object value)
    {
        return ((double)value).ToString("C0", CultureInfo.CreateSpecificCulture("ru-RU"));
    }

    private async Task CreateStat()
    {
        orderForFirstDate = await DiagramService.GetOrdersByDate(startDate, endDate, firstAssetId);
        // orderForSecondDate = await DiagramService.GetOrdersByDate(endDate);

    }

    string FormatAsMonth(object value)
    {
        if (value != null)
        {
            return Convert.ToDateTime(value).ToString("M");
        }

        return string.Empty;
    }
}
