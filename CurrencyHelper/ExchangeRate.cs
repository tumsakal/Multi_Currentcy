using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyHelper
{
    public sealed class ExchangeRate
    {
        public ICurrencyQuery QuerySource { private get; set; }
        public string[] Currencies { get; private set; }
        public Dictionary<string, double> BuyInList { get; private set; }
        public Dictionary<string, double> SaleOutList { get; private set; }
        public void QuerExchangeRate()
        {
            if (this.QuerySource == null)
                throw new Exception("Currency Source is NULL");
            this.Currencies = this.QuerySource.QueryCurrencies();
            this.BuyInList = this.QuerySource.QueryBuyInRate();
            this.SaleOutList = this.QuerySource.QuerySaleOutRate();
        }
    }
}
