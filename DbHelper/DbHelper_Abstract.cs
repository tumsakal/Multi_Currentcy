using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbHelper
{
    public abstract class DbHelper
    {
        public abstract void ExecuteQuery(string text);
    }
}
