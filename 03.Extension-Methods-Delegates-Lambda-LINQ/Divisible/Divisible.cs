namespace Divisible
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Divisible
    {
        static void Main()
        {
            var list = new List<int>{5, 6, 7, 21, 30, 35, 5, 42};
            Console.WriteLine("Numbers divisible by 7 and 3 with lamda:");
            var resultLambda =
                list.Where(number => number % 3 == 0 && number % 7 == 0);
            foreach (var number in resultLambda)
            {
                Console.WriteLine(number);
            }

            var resultWithLinq =
                from number in list
                where number % 3 == 0 && number % 7 == 0
                select number;
            Console.WriteLine();
            Console.WriteLine("Numbers divisible by 7 and 3 with linq:");

            foreach (var number in resultWithLinq)
            {
                Console.WriteLine(number);
            }
        }
    }
}
