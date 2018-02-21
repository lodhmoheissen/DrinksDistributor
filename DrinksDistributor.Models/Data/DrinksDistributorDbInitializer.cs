using DrinksDistributor.Models.Entities;
using System.Collections.Generic;
using System.Data.Entity;

namespace DrinksDistributor.Models.Data
{
    /// <summary>
    /// Class that represents a DrinksDistributor database initializer.
    /// </summary>
    public class DrinksDistributorDbInitializer : CreateDatabaseIfNotExists<DrinksDistributorContext>
    {
        /// <summary>
        /// Seed the database, using Code First approach and the database context.
        /// </summary>
        /// <param name="context">EF database context</param>
        protected override void Seed(DrinksDistributorContext context)
        {
            // Coin currencies definition.
            CoinCurrency chf = new CoinCurrency() { IsoCode3 = "CHF", Symbol = "CHF", Name = "Swiss franc" };
            CoinCurrency eur = new CoinCurrency() { IsoCode3 = "EUR", Symbol = "€", Name = "Euro" };
            CoinCurrency usd = new CoinCurrency() { IsoCode3 = "USD", Symbol = "$", Name = "United States Dollar" };
            CoinCurrency gbp = new CoinCurrency() { IsoCode3 = "GBP", Symbol = "£", Name = "Great Britain Pound" };
            IList<CoinCurrency> codeCurrencies = new List<CoinCurrency>() { chf, eur, usd, gbp };

            // Currencies definition.
            CoinType chf005 = new CoinType { Code = "CHF0.05", CoinCurrency = chf, Name = "0.05 Swiss franc", Value = 0.05 };
            CoinType chf010 = new CoinType { Code = "CHF0.10", CoinCurrency = chf, Name = "0.10 Swiss franc", Value = 0.10 };
            CoinType chf020 = new CoinType { Code = "CHF0.20", CoinCurrency = chf, Name = "0.20 Swiss franc", Value = 0.20 };
            CoinType chf050 = new CoinType { Code = "CHF0.50", CoinCurrency = chf, Name = "0.50 Swiss franc", Value = 0.50 };
            CoinType chf100 = new CoinType { Code = "CHF1.00", CoinCurrency = chf, Name = "1 Swiss franc", Value = 1.00 };
            CoinType chf200 = new CoinType { Code = "CHF2.00", CoinCurrency = chf, Name = "2 Swiss francs", Value = 2.00 };
            CoinType chf500 = new CoinType { Code = "CHF5.00", CoinCurrency = chf, Name = "5 Swiss francs", Value = 5.00 };
            IList<CoinType> codeTypes = new List<CoinType>() { chf005, chf010, chf020, chf050, chf100, chf200, chf500 };

            // Coin stock definition.
            CoinStock stockChf005 = new CoinStock { CoinType = chf005, Quantity = 10 };
            CoinStock stockChf010 = new CoinStock { CoinType = chf010, Quantity = 10 };
            CoinStock stockChf020 = new CoinStock { CoinType = chf020, Quantity = 10 };
            CoinStock stockChf050 = new CoinStock { CoinType = chf050, Quantity = 10 };
            CoinStock stockChf100 = new CoinStock { CoinType = chf100, Quantity = 10 };
            CoinStock stockChf200 = new CoinStock { CoinType = chf200, Quantity = 10 };
            CoinStock stockChf500 = new CoinStock { CoinType = chf500, Quantity = 10 };
            IList<CoinStock> stocksChf = new List<CoinStock>() { stockChf005, stockChf010, stockChf020, stockChf050, stockChf100, stockChf200, stockChf500 };

            // Drinks definition.
            Drink water = new Drink { Code = "WATERCHF", Name = "Water (CHF)", Price = 1.10, PriceCurrency = chf };
            Drink cola = new Drink { Code = "COCACHF", Name = "Coca-Cola (CHF)", Price = 1.20, PriceCurrency = chf };
            Drink fanta = new Drink { Code = "FANTACHF", Name = "Fanta (CHF)", Price = 1.60, PriceCurrency = chf };
            IList<Drink> drinks = new List<Drink>() { water, cola, fanta };

            // Add definitions.
            context.CoinCurrencies.AddRange(codeCurrencies);
            context.CoinTypes.AddRange(codeTypes);
            context.CoinStocks.AddRange(stocksChf);
            context.Drinks.AddRange(drinks);

            // Default seeding.
            base.Seed(context);
        }
    }
}
