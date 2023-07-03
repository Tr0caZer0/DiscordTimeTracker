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

        //Takes total time and starts count down.
        public void StartTimer(int capTimeMin)
        {

            var count = 1;

            while(true)
            {
                Thread.Sleep(1000);
                Console.WriteLine(count);
                count++;

                if (count > capTimeMin)
                {
                    Console.WriteLine("You Suck!");

                    break;
                }
            }
            
        }
    }
}
