using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyConverter
{
    public class Converter
    {
        public Currency FirstCurrency { get; set; }
        public Currency SecondCurrency { get; set; }
        public double Amount { get; set; }
        public double ConvertedAmount { get; set; }

        public static List<Currency> currencies = new List<Currency>
        {
            new Currency
            {
                Valuta = "HRK",
                Tecaj = 1
            },
            new Currency
            {
                Valuta = "EUR",
                Tecaj = 7.4
            },
            new Currency
            {
                Valuta = "USD",
                Tecaj = 6.5
            },
            new Currency
            {
                Valuta = "GBP",
                Tecaj = 8.5
            },
            new Currency
            {
                Valuta = "CAD",
                Tecaj = 4.9
            }
        };

        public static Currency getCurrency(string valuta)
        {
            foreach (Currency currency in currencies)
            {
                if (currency.Valuta == valuta)
                {
                    return currency;
                }
            }
            return null;
        }
    }
}
