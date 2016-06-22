namespace _17.LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LongestStringMain
    {
        static void Main()
        {
            var list = new List<string>()
            {
                "I am the fisrt string",
                "hello",
                "how are you today?",
                "I am the longest string in this list",
                "last string"
            };

            var longestString =
                from str in list
                orderby str.Length descending
                select str;

            var longestStr = longestString.FirstOrDefault();
            Console.WriteLine(longestStr);
        }
    }
}
