using Microsoft.AspNetCore.Components;

namespace EconomicsProject_3_Front;

public class DiagramService
{
    private readonly DataContextService dataContextService;
    public decimal Amount { get; set; }

    public DiagramService(DataContextService dataContextService)
    {
        this.dataContextService = dataContextService;
    }

    public async Task<IEnumerable<DiagramServiceModel>> GetOrdersByDate(DateTime StartDate, DateTime SecondDate, string assetName)
    {
        var t = dataContextService.GetDataContext();
        var orders = dataContextService.GetDataContext().Assets
            .Where(d => d.SellDate >= StartDate 
            && d.SellDate < SecondDate
            && d.AssetCode == assetName).ToList();

        var days = new List<DateTime>();

        for (DateTime date = StartDate; date <= SecondDate; date = date.AddDays(1))
            days.Add(date);

        var ordersDates = new List<DateTime>();

        foreach (var order in orders)
            ordersDates.Add(DateTime.Parse(order.SellDate.ToString("yyyy-MM-dd")));
        var resultDates = ordersDates.Intersect(days);

        var diagramServiceModel = new List<DiagramServiceModel>();

        foreach (var item in resultDates)
        {
            var ordersInCurrentDate = dataContextService.GetDataContext().Assets
                .Where(d => d.SellDate.Day == item.Date.Day 
                && d.SellDate.Month == item.Date.Month
                && d.AssetCode == assetName).ToList();

            foreach (var order in ordersInCurrentDate)
            {
                Amount += order.TotalOrderAmount;
            }
            diagramServiceModel.Add(new DiagramServiceModel { Date = item.Date, AmountForDate = Math.Round(Amount, 0) });
            Amount = 0;
        }

        return diagramServiceModel;
    }
}
