using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbHelper;

namespace CurrencyHelper
{
    public class DbQueryExchangeRate : ICurrencyQuery
    {
        public DbHelper.DbHelper dbClient { get; set; }
        public Dictionary<string, double> QueryBuyInRate()
        {
            dbClient.ExecuteQuery("");
            throw new NotImplementedException();
        }

        public string[] QueryCurrencies()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, double> QuerySaleOutRate()
        {
            throw new NotImplementedException();
        }
    }
}
