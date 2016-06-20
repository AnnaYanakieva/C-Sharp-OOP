namespace GenericClass5_7
{
    using System;
    using System.Collections.Generic;
    class GenericListMain
    {
        static void Main(string[] args)
        {
            var testList = new GenericList<int>(8);
            testList.Add(5);
            testList.Add(15);
            testList.Add(25);

            // Console.WriteLine(testList[6]);
            testList.RemoveAtIndex(1);
            testList.InsertAtIndex(1, 322);
            testList.InsertAtIndex(2, 422);
            testList.InsertAtIndex(1, 522);

            Console.WriteLine("Elements in List:");
            Console.WriteLine(testList);
            Console.WriteLine()
                ;
            //  Console.WriteLine(testList[3]); 
            Console.WriteLine("Max element in list {0}", testList.Max());
            Console.WriteLine("Min element in list {0}", testList.Min());
        }
    }
}
