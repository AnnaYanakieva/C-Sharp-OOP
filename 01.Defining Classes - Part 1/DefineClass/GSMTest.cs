namespace DefineClass
{
    using System;
    using System.Collections.Generic;
    class GSMTest
    {
        public static void Main()
        {
            GSM[] arr = new GSM[5]
            {
                new GSM("Lumia","Nokia",500,"Ivan"),
                new GSM("S6","Samsung",1000,"Maria"),
                new GSM("6S","iPhone",1500,"Pesho"),
                new GSM("P6","Huawei",690.50,"John"),
                new GSM("6", "iPhone",1300,"Ginka")
            };
            
            foreach (var phone in arr)
            {
                Console.WriteLine(phone);
            }
            Console.WriteLine();

            GSM myGSM = new GSM("Lumia", "Nokia", 500, "Ivan");

            myGSM.AddCalls(new Call(60));
            myGSM.AddCalls(new Call(120));
            myGSM.AddCalls(new Call(20));
            myGSM.AddCalls(new Call(10));

            for (int i = 0; i < myGSM.CallHistory.Count; i++)
            {
                Console.WriteLine("Call {0} duration: {1}sec",i+1,myGSM.CallHistory[i].DurationInSeconds);                
            }
            Console.WriteLine();
            Console.WriteLine("Total price of all calls: {0}",myGSM.CalculateTotalPriceOfCalls());

            int longestCall = int.MinValue;
            for (int i = 1; i < myGSM.CallHistory.Count; i++)
            {

                int currentMax = Math.Max(myGSM.CallHistory[i - 1].DurationInSeconds, myGSM.CallHistory[i].DurationInSeconds);
                if (longestCall<currentMax)
                {
                    longestCall = currentMax;
                }
            }
            for (int i = 0; i < myGSM.CallHistory.Count; i++)
            {
                if (myGSM.CallHistory[i].DurationInSeconds==120)
                {
                    myGSM.CallHistory.RemoveAt(i);
                }
            }
            Console.WriteLine("Total price of all calls after removing longest call : {0}", myGSM.CalculateTotalPriceOfCalls());
            myGSM.ClearCallHistory();

            for (int i = 0; i < myGSM.CallHistory.Count; i++)
            {
                Console.WriteLine("After clear {0}",myGSM.CallHistory[i].DurationInSeconds);
            }            
        }
    }
}
