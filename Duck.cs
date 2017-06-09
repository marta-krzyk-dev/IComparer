using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckList
{
    public enum KindOfDuck { Mallard, Muscovy, Decoy};

    public class Duck : IComparable<Duck>
    {
        public int Size { get; set; }
        public KindOfDuck Kind { get; set; }

        public void Print()
        {
            Console.WriteLine("Duck: " + Kind + ", " + Size);
        }

        public override string ToString()
        {
 	        return "Duck: " + Kind + ", " + Size;
        }

        public int CompareTo(Duck duckToCompare)
        {
            if (this.Size > duckToCompare.Size)
                return 1;
            else
                if (this.Size < duckToCompare.Size)
                    return -1;
                else
                    return 0;
        }
    }
}
