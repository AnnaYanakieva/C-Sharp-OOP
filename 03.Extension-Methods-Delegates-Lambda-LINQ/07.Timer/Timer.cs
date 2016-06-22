namespace _07.Timer
{
    using System;
    using System.Diagnostics;

    public delegate void SimpleDelegate();
    public class Timer
    {
        private readonly int t;

        public Timer(int t)
        {
            this.t = t;
        }
        public void InvokeDelegate()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var myDelegate = new SimpleDelegate(SayHello);

            while (true)
            {
                if (stopwatch.Elapsed.Seconds != this.t)
                {
                    continue;
                }

                myDelegate.Invoke();
                stopwatch.Restart();
            }
        }
       
        private static void SayHello()
        {
            Console.WriteLine("Hello!");
        }
    }
}
