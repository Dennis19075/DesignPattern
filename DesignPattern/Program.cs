// See https://aka.ms/new-console-template for more information
using DesignPattern.FactoryPattern;
using DesignPattern.Singleton;


//SINGLETON PATTERN
Console.WriteLine("Hello, World!");

var singleton = Singleton.Instance;

var log = Log.Instance;

log.Save("saito");
log.Save("inosaka");

var a = Singleton.Instance;
var b = Singleton.Instance;

Console.WriteLine(a == b);

//FACTORY METHOD PATTERN
//adding 10 extra bucks
SaleFactory storeSaleFactory = new StoreSaleFactory(10);
//Discounting 15$
SaleFactory internetSaleFactory = new InternetSaleFactory(15);

ISale sale1 = storeSaleFactory.GetSale();
sale1.Sell(100);
ISale sale2 = internetSaleFactory.GetSale();
sale2.Sell(120);