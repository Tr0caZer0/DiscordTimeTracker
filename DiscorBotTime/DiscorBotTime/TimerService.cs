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
        

        public void StartTimer(int capTimeMin)
        {
            //var maxTime = 2;
            //var timer = new Timer(FinishedTime, null, 0, 100000);

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

        public int[,]  SplitTime(string timeToRecall)
        {
            String[] splitTime = timeToRecall.Split(':');

            int[,] minutesAndSeconds = new int[1,2];

            if (splitTime.Length == 2)
            {
                for (int i = 0; i < splitTime.Length; i++)
                {
                    minutesAndSeconds[0,i] = int.Parse(splitTime[i]);
                }
                
            }

            foreach (var i in splitTime)
            {
                Console.WriteLine(i);
            }

            return minutesAndSeconds;
            
        }

        public int MinutesAndSecondForTimer(int[,] createInputToSeconds)
        {
            var minutes = 0;
            var seconds = 0;

            for (int i = 0; i < createInputToSeconds.Length-1; i++)
            {
                minutes = createInputToSeconds[i,0];
                
                seconds = createInputToSeconds[i,1];
               
                
            }

            minutes = minutes * 60;

            var totalTime = minutes + seconds;

            return totalTime;

        }
    }
}
