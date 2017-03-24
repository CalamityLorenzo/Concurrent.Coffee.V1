using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrent.Coffee.V1.CoffeeShop
{
    static class Utility
    {
        static void Wait(string message, int milliToWait)
        {
            Console.WriteLine(message);
            var myWaiter = ThreadSleeper(".", 100);

            myWaiter(3000);
        }
       
        static Func<int, bool> ThreadSleeper(string Cursor, int interval)
        {
            return (timeToWait) =>
            {
                var timeTaken = 0;
                var WaitInterval = interval;
                while (timeTaken <= timeToWait)
                {
                    Console.Write(".");
                    System.Threading.Thread.Sleep(WaitInterval);
                    timeTaken += WaitInterval;
                }
                return true;
            };
        }
    }
}
