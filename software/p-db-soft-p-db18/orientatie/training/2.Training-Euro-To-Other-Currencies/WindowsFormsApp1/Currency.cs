using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Currency
    {
        readonly string name;
        readonly string symbol;
        readonly decimal euroExchangeRate;

        public Currency(string name, string symbol, decimal euroExchangeRate)
        {
            this.name = name;
            this.symbol = symbol;
            this.euroExchangeRate = euroExchangeRate;
        }

        public string GetName()
        {
            return this.name;
        }
        public string GetSymbol()
        {
            return this.symbol;
        }
        public decimal GetEuroExchangeRate()
        {
            return this.euroExchangeRate;
        }
    }
}
