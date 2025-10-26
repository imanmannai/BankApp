using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class CurrencyRate
    {
        public string RateID { get; set; }  
        public string FromCurrency { get; set; }
        public string ToCurrency { get; set; }
        public decimal ExchangeRate { get; set; } // e.g., 1 FromCurrency = ExchangeRate ToCurrency

        public DateTime LastUpdated { get; set; } // Timestamp of when the rate was last changed (by Admin).
    }
}
