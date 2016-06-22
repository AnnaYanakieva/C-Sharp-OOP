namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    class MainClass
    {
        static void Main()
        {
            var list = new List<int>() { 1, 2, 3, 4 };
            Console.WriteLine("Collection : {0}", (string.Join(", ", list)));
            Console.WriteLine("Sum of collection: {0}", list.CollectionSum());
            Console.WriteLine("Product of collection: {0}", list.CollectionProduct());
            Console.WriteLine("Min value in collection: {0}", list.CollectionMinElement());
            Console.WriteLine("Max value in collection: {0}", list.CollectionMaxElement());
            Console.WriteLine("Average of collection: {0:0.00}", list.CollectionAverage());
        }
    }
}
