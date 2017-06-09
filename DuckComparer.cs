using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckList
{
    public enum SortCriteria { SizeThenKind, KindThenSize};

    class DuckComparer: IComparer<Duck>
    {
        public SortCriteria SortBy = SortCriteria.SizeThenKind;

        public int Compare(Duck a, Duck b)
        {
            if (SortBy == SortCriteria.KindThenSize)
            {
                if (a.Kind > b.Kind)
                    return 1;
                else
                    if (a.Kind < b.Kind)
                        return -1;
                    else
                    {
                        if (a.Size > b.Size)
                            return 1;
                        else if (a.Size < b.Size)
                            return -1;
                        else
                            return 0;
                    }
            }
            else
            {
                if (a.Size > b.Size)
                    return 1;
                else
                    if (a.Size < b.Size)
                        return -1;
                    else
                    {
                        if (a.Kind > b.Kind)
                            return 1;
                        else if (a.Kind < b.Kind)
                            return -1;
                        else
                            return 0;
                    }
            }
        }
    }
}
