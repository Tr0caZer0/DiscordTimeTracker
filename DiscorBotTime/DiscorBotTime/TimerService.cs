using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace DiscorBotTime
{
    public class TimerService
    {
        

        public void StartTimer(int capTime)
        {
            //var maxTime = 2;
            //var timer = new Timer(FinishedTime, null, 0, 100000);

            var count = 1;

            while(true)
            {
                Thread.Sleep(1000);
                Console.WriteLine(count);
                count++;

                if (count > capTime)
                {
                    Console.WriteLine("You Suck!");

                    break;
                }
            }
            
        }

        private static void FinishedTime(object state)
        {
            Console.WriteLine("Hej");


        }
    }
}
