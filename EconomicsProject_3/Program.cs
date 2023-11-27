﻿
using EconomicsProject_3;

var firstAsset = new Asset() { Name = "Гамбургеры", Count = 700, Price = 300, AssetType = AssetTypes.Product };
var secondAsset = new Asset() { Name = "Гамбургеры", Count = 800, Price = 250, AssetType = AssetTypes.Product };
var formaulas = new Formulas();

Console.WriteLine("первый товар спрос " + firstAsset.Count);
Console.WriteLine("первый товар цена " + firstAsset.Price);
Console.WriteLine("второй товар спрос " + secondAsset.Count);
Console.WriteLine("второй товар цена " + secondAsset.Price);
var elasticity = formaulas.GetPriceElasticityOfDemand(firstAsset, secondAsset);
Console.WriteLine("эластичность спроса по цене " + elasticity);
if (elasticity == 0)
    Console.WriteLine("спрос едничной эластичности");
else if (elasticity < 0)
    Console.WriteLine("спрос неэластичен");
else if (elasticity > 1)
    Console.WriteLine("эластичный спрос");
Console.WriteLine();
var firstAsset1 = new Asset() { Name = "Гамбургеры", Count = 750, Price = 330, AssetType = AssetTypes.Product };
var secondAsset1 = new Asset() { Name = "Гамбургеры", Count = 1000, Price = 400, AssetType = AssetTypes.Product };
Console.WriteLine("первый товар спрос " + firstAsset1.Count);
Console.WriteLine("первый товар цена " + firstAsset1.Price);
Console.WriteLine("второй товар спрос " + secondAsset1.Count);
Console.WriteLine("второй товар цена " + secondAsset1.Price);
var elasticityOfDemand = formaulas.GetElasticityOfPriceOffer(firstAsset1, secondAsset1);
Console.WriteLine("эластичность предложения по цене " + elasticityOfDemand);
if (elasticityOfDemand == 0)
    Console.WriteLine("предложение едничной эластичности");
else if (elasticityOfDemand < 0)
    Console.WriteLine("предложение неэластично");
else if (elasticityOfDemand > 1)
    Console.WriteLine("предложение эластично");