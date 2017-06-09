using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Projekt z książki C# Head rush , str. 403
namespace DuckList
{
    class Program
    {
        static List<Duck> ducks = new List<Duck>() 
        { 
            new Duck() {Kind = KindOfDuck.Mallard, Size = 17},
            new Duck() {Kind = KindOfDuck.Decoy, Size = 16},
            new Duck() {Kind = KindOfDuck.Mallard, Size = 18},
            new Duck() {Kind = KindOfDuck.Mallard, Size = 10},
            new Duck() {Kind = KindOfDuck.Muscovy, Size = 10},
            new Duck() {Kind = KindOfDuck.Decoy, Size = 12},
            new Duck() {Kind = KindOfDuck.Muscovy, Size = 8},
            new Duck() {Kind = KindOfDuck.Decoy, Size = 20},
        };

        static void Main(string[] args)
        {
            //SORT BY SIZE----------------------------------------
            Console.WriteLine("Ducks:");

            foreach (Duck d in ducks)
                d.Print();

            ducks.Sort();
            //or
            ducks.Sort(new DuckComparerBySize());

            Console.WriteLine("\nSorted ducks:");

            foreach (Duck d in ducks)
                d.Print();

            //SORT BY KIND----------------------------------------

            ducks.Sort(new DuckComparerByKind());

            Console.WriteLine("\nSorted by kind:");

            foreach (Duck d in ducks)
                d.Print();

            //SORT BY KIND THEN SIZE

            var duckComparer = new DuckComparer { SortBy = SortCriteria.KindThenSize };
            ducks.Sort(duckComparer);

            Console.WriteLine("\nSorted by kind then size:");
            foreach (Duck d in ducks)
                d.Print();

            //SORT BY KIND THEN SIZE

            duckComparer.SortBy = SortCriteria.SizeThenKind;
            ducks.Sort(duckComparer);

            Console.WriteLine("\nSorted by size then kind:");
            foreach (Duck d in ducks)
                d.Print();

            Console.ReadKey();


        }
    }
}
