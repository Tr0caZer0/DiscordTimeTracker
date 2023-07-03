using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscorBotTime
{
    public class ConvertInput
    {
        // Method splits user input and parses it into integers. Copies integers into 2d array.
        public int[,] SplitTime(string timeToRecall)
        {
            String[] splitTime = timeToRecall.Split(':');

            int[,] minutesAndSeconds = new int[1, 2];

            // need to add error handelning to make sure format is followed min:sec
            if (splitTime.Length == 2)
            {
                for (int i = 0; i < splitTime.Length; i++)
                {
                    minutesAndSeconds[0, i] = int.Parse(splitTime[i]);
                }

            }

            // only for follow up to make sure the input is correctly transfered to 2d array
            foreach (var i in minutesAndSeconds)
            {
                Console.WriteLine(i);
            }

            return minutesAndSeconds;

        }

        // method to add minutes and seconds together
        public int MinutesAndSecondForTimer(int[,] createInputToSeconds)
        {
            var minutes = 0;
            var seconds = 0;

            for (int i = 0; i < createInputToSeconds.Length - 1; i++)
            {
                minutes = createInputToSeconds[i, 0];

                seconds = createInputToSeconds[i, 1];


            }

            minutes = minutes * 60;

            var totalTime = minutes + seconds;

            return totalTime;

        }
    }
}
