using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace DiscorBotTime
{
    public static class TimerService
    {
        public static bool gotResponse { get; set; }

        //Takes total time and starts count down.
        public static void StartTimer(int capTimeMin)
        {
            var count = 1;

            while(!gotResponse)
            {
                Thread.Sleep(1000);
                Console.WriteLine(count);
                count++;

                if (count > capTimeMin)
                {
                    Console.WriteLine("You Suck!");
                    gotResponse = true;
                    break;
                }
            }
            
        }
    }
}
