using System;
using System.Linq;

namespace DrinksDistributor.Models
{
    /// <summary>
    /// Little program to test the EF model we build from CodeFirst.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main entry point method.
        /// </summary>
        /// <param name="args">Program arguments</param>
        static void Main(string[] args)
        {
            using (var db = new DrinksDistributorContext())
            {
                // CoinCurrencies
                var queryCoinCurrency = from o in db.CoinCurrencies orderby o.IsoCode3 select o;
                Console.WriteLine("All coin currencies in the database:");
                foreach (var item in queryCoinCurrency)
                {
                    Console.WriteLine(item.ToString());
                }

                // CoinTypes
                var queryCoinTypes = from o in db.CoinTypes orderby o.Code select o;
                Console.WriteLine("All coin types in the database:");
                foreach (var item in queryCoinTypes)
                {
                    Console.WriteLine(item.ToString());
                }

                // CoinStocks
                var queryCoinStocks = from o in db.CoinStocks orderby o.Id select o;
                Console.WriteLine("All coin stocks in the database:");
                foreach (var item in queryCoinStocks)
                {
                    Console.WriteLine(item.ToString());
                }

                // Drinks
                var queryDrinks = from o in db.Drinks orderby o.Id select o;
                Console.WriteLine("All drinks in the database:");
                foreach (var item in queryDrinks)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
    }
}
