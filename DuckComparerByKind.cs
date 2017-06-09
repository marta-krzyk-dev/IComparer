using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckList
{
    class DuckComparerByKind : IComparer<Duck>
    {
        public int Compare(Duck a, Duck b)
        {
            if (a.Kind > b.Kind)
                return 1;
            else
                if (a.Kind < b.Kind)
                    return -1;
                else
                    return 0;
        }
    }
}
