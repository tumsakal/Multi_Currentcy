using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyHelper
{
    public interface ICurrencyQuery
    {
        string[] QueryCurrencies();
        Dictionary<string, double> QueryBuyInRate();
        Dictionary<string, double> QuerySaleOutRate();

    }
}