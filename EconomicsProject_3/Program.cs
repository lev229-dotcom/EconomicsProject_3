
using EconomicsProject_3;
using EconomicsProject_3_Core.Domain;
using EconomicsProject_3_Core.Formuls;

var firstAsset = new Asset() { Name = "Пряники", Count = 1400, Price = 300 };
var secondAsset = new Asset() { Name = "Пряники", Count = 800, Price = 250 };
var formaulas = new Formulas();
var l = new List<Asset>
{
    firstAsset,
    secondAsset
};

var test = l.Sum(_ => _.Price * _.Count);

Console.WriteLine("первый товар спрос " + firstAsset.Count);
Console.WriteLine("первый товар цена " + firstAsset.Price);
Console.WriteLine("второй товар спрос " + secondAsset.Count);
Console.WriteLine("второй товар цена " + secondAsset.Price);
var elasticity = formaulas.GetPriceElasticityOfDemand(firstAsset, secondAsset);
//Когда эластичность >1, то это говорит о том что раньше продавали намного больше 
// Когда эластичность < -1, значит что спрос увеличился и сейчас продаем намного больше
// Если эластичность в промежутке от -1 до 1, то значит что изменение цены не повлияло на спрос
Console.WriteLine("эластичность спроса по цене " + elasticity);
if (elasticity == 0)
    Console.WriteLine("спрос едничной эластичности");
else if (elasticity < 0)
    Console.WriteLine("спрос неэластичен. Необходимо ");
else if (elasticity > 1)
    Console.WriteLine("эластичный спрос");
Console.WriteLine();

var firstAsset1 = new Asset() { Name = "Пряники", Count = 750, Price = 330 };
var secondAsset1 = new Asset() { Name = "Пряники", Count = 1000, Price = 400 };
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