namespace ExtensionMethod
{
    using System;
    public class StringBuilderSubstrMain
    {
        static void Main()
        {
            string test = "Hello, how are you?";
            Console.WriteLine(test.SubstringExtension(0, 5));
        }
    }
}
