// See https://aka.ms/new-console-template for more information
using DiscorBotTime;
var serivice = new TimerService();

Console.WriteLine("Set timer in minutes and seconds(e.g. 12:30)");
string timeToRecall = Console.ReadLine();


int [,] minutesAndSeconds = serivice.SplitTime(timeToRecall);

//Console.Clear();

var totalTime = serivice.MinutesAndSecondForTimer(minutesAndSeconds);

Console.WriteLine("Timer starts");

serivice.StartTimer(totalTime);
