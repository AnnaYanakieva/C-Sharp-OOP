namespace _07.Timer
{
   public class TimerMain
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(1);
            timer.InvokeDelegate();
        }
    }
}
