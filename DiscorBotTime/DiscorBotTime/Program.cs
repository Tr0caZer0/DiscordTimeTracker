// See https://aka.ms/new-console-template for more information
using DiscorBotTime;
var tSerivice = new TimerService();
var cSerivice = new ConvertInput();

Console.WriteLine("Set timer in minutes and seconds(e.g. 12:30)");
string timeToRecall = Console.ReadLine();

// Takes user input and cals on SplitTime method to create array of integers.
int [,] minutesAndSeconds = cSerivice.SplitTime(timeToRecall);

//Console.Clear();

// calls on MinutesAndSecondsForTimer method taking array from SplitTime method
var totalTime = cSerivice.MinutesAndSecondForTimer(minutesAndSeconds);

Console.WriteLine("Timer starts");

// calls on StartTimer method taking values from MinutesAndSecondsForTimer method
tSerivice.StartTimer(totalTime);
