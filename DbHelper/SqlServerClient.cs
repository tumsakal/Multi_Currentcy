using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbHelper
{
    public sealed class SqlServerClient : DbHelper
    {
        public override void ExecuteQuery(string text)
        {
            throw new NotImplementedException();
        }
    }
}
