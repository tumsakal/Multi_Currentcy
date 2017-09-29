using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyHelper
{
    public sealed class Money
    {
        public ExchangeRate ExchangeRate
        {
            get
            {
                return null;
            }
            set
            {

            }
        }
        public double Amount { get; set; }
        public string Currency { get; set; }
        private Dictionary<string, double> BuyInList { get; set; }
        private Dictionary<string, double> SaleOutList { get; set; }

        public Money(double amount, string currency)
        {
            this.Amount = amount;
            this.Currency = currency;
            //this.BuyInList = exchangeRate.QureyBuyInRate();
            //this.SaleOutList = exchangeRate.QureySaleOutRate();
        }
        public Money(double amount, string currency, ExchangeRate ExchangeRate)
        {
            this.Amount = amount;
            this.Currency = currency;
            //this.BuyInList = exchangeRate.QureyBuyInRate();
            //this.SaleOutList = exchangeRate.QureySaleOutRate();
        }
        public double ExchangeTo(string currency)
        {
            return 0;
        }
        public double ExchangeFrom(string currency)
        {
            return 0;
        }
    }
}
