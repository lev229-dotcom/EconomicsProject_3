using CsvHelper;
using CsvHelper.Configuration;
using EconomicsProject_3_Core.Data;
using EconomicsProject_3_Core.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Data.SqlClient.Server;
using Microsoft.EntityFrameworkCore;
using Radzen;
using Radzen.Blazor;
using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace EconomicsProject_3_Front.Pages;

public partial class Index
{
    RadzenDataGrid<Asset> ordersGrid;
    IEnumerable<Asset> assets;
    [Inject] DataContextService dataContextService { get; set; }

    Asset orderToInsert;
    Asset orderToUpdate;
    protected override async Task OnInitializedAsync()
    {
       assets = await dataContextService.GetDataContext().Assets.ToListAsync();
    }

    private async Task EditRow(Asset asset)
    {
        orderToUpdate = asset;
        await ordersGrid.EditRow(asset);
    }
    private void DeleteRow(Asset asset)
    {
        Reset();

        dataContextService.GetDataContext().Remove(asset);

        dataContextService.GetDataContext().SaveChanges();
    }
    private async Task SaveRow(Asset asset)
    {
        await ordersGrid.UpdateRow(asset);
    }
    private void CancelEdit(Asset asset)
    {
        Reset();

        ordersGrid.CancelEditRow(asset);

        var orderEntry = dataContextService.GetDataContext().Entry(asset);
        if (orderEntry.State == EntityState.Modified)
        {
            orderEntry.CurrentValues.SetValues(orderEntry.OriginalValues);
            orderEntry.State = EntityState.Unchanged;
        }
    }

    void OnUpdateRow(Asset order)
    {
        Reset();

        dataContextService.GetDataContext().Update(order);

        dataContextService.GetDataContext().SaveChanges();
    }

    private void Reset()
    {
        orderToInsert = null;
        orderToUpdate = null;
    }

    async Task InsertRow()
    {
        orderToInsert = new Asset();
        await ordersGrid.InsertRow(orderToInsert);
    }

    void OnCreateRow(Asset order)
    {
        dataContextService.GetDataContext().Add(order);

        dataContextService.GetDataContext().SaveChanges();

        orderToInsert = null;
    }

    private async Task UploadFiles(IBrowserFile file)
    {
        var assets = new List<Asset>();
        var data = await GetData(file);
        using (var memoryStream = new MemoryStream(Convert.FromBase64String(data)))
        {
            using(var reader = new StreamReader(memoryStream, Encoding.UTF8))
            {

                //using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Context.RegisterClassMap<AssetMap>();
                    var records = csv.GetRecords<Asset>();
                    assets = csv.GetRecords<Asset>().ToList();
                }

                //var lines = reader.ReadToEnd().Split(';');
                ////File.ReadAllLines(reader).Select(a => a.Split(';'));
                //var csv = from line in lines
                //          select (line.Split(';')).ToArray();
                //from line in lines
                //      select (from piece in line
                //              select piece);
            }
        }
        var db = dataContextService.GetDataContext();
        foreach (var asset in assets)
        {
             db.Add(asset);
             db.SaveChanges();
        }
        assets = await dataContextService.GetDataContext().Assets.ToListAsync();

    }

    public async Task<string> GetData(IBrowserFile file)
    {
        var path = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());

        await using var fs = new FileStream(path, FileMode.Create);

        await file.OpenReadStream(file.Size).CopyToAsync(fs);

        var bytes = new byte[file.Size];

        fs.Position = 0;

        await fs.ReadAsync(bytes);

        fs.Close();

        File.Delete(path);

        return await Task.FromResult(Convert.ToBase64String(bytes));
    }

    private string[] SplitCSV(string input)
    {
        //Excludes commas within quotes  
        Regex csvSplit = new Regex("(?:^|,)(\"(?:[^\"]+|\"\")*\"|[^,]*)", RegexOptions.Compiled);
        List<string> list = new List<string>();
        string curr = null;
        foreach (Match match in csvSplit.Matches(input))
        {
            curr = match.Value;
            if (0 == curr.Length) list.Add("");

            list.Add(curr.TrimStart(','));
        }

        return list.ToArray();
    }
}

public sealed class AssetMap : ClassMap<Asset>
{
    public AssetMap()
    {
        AutoMap(CultureInfo.InvariantCulture);
        Map(m => m.Id).Ignore();
    }
}
