using System;
using System.Collections.Generic;
using System.Linq;

namespace StockPurchaseDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("GME", "Gamestop");
            stocks.Add("BBBY", "Bed Bath & Beyond");
            stocks.Add("LOGI", "Logitech International");
            stocks.Add("A", "Agilent Technologies");


            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();
            purchases.Add((ticker: "GM", shares: 150, price: 23.21));
            purchases.Add((ticker: "CAT", shares: 32, price: 17.87));
            purchases.Add((ticker: "GME", shares: 53, price: 28.65));
            purchases.Add((ticker: "BBBY", shares: 90, price: 10.92));
            purchases.Add((ticker: "LOGI", shares: 11, price: 65.89));
            purchases.Add((ticker: "LOGI", shares: 34, price: 65.89));
            purchases.Add((ticker: "A", shares: 34, price: 65.89));


            string GM = stocks["GM"];
            string CAT = stocks["CAT"];
            string GME = stocks["GME"];
            string BBBY = stocks["BBBY"];
            string LOGI = stocks["LOGI"];

            Dictionary<string, double> ownershipReport = new Dictionary<string, double>();

            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                if (ownershipReport.ContainsKey(stocks[purchase.ticker]))
                {
                    var totalOwnerShipReport = ownershipReport[stocks[purchase.ticker]] * purchase.shares * purchase.price;
                    ownershipReport[stocks[purchase.ticker]] = totalOwnerShipReport;
                }
                else
                {
                    var AddToTotal = purchase.shares * purchase.price;
                    ownershipReport.Add(stocks[purchase.ticker], AddToTotal);
                }
            }

            foreach (var (key, value) in ownershipReport)
            {
                Console.WriteLine($"{key}: {value}");
            }

        }

    }
}
