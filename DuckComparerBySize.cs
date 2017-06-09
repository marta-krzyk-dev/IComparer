using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckList
{
    class DuckComparerBySize : IComparer<Duck>
    {
        public int Compare(Duck a, Duck b)
        {
            if (a.Size > b.Size)
                return 1;
            else
                if (a.Size < b.Size)
                    return -1;
                else
                    return 0;
        }
    }
}
