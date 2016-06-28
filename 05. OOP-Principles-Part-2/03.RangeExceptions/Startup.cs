namespace _03.RangeExceptions
{
    using System;

    public class Startup
    {
        static void Main()
        {
            try
            {
                int number = 101;
                if (number < 1 || number > 100)
                {
                    throw new InvalidRangeException<int>("Invalid input, please enter a value in the range\n[1..100]!", 1, 100);
                }
            }

            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();

            try
            {
                DateTime date = new DateTime(2016, 06, 28);
                if (date < new DateTime(1980, 01, 01) || date > new DateTime(2013, 12, 31))
                {
                    throw new InvalidRangeException<DateTime>("Invalid input, please enter a date in the range\n[1.1.1980..31.12.2013]!",
                    new DateTime(1980, 01, 01), new DateTime(2013, 12, 31));
                }
            }

            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
