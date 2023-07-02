// See https://aka.ms/new-console-template for more information
using DiscorBotTime;
var serivice = new TimerService();

Console.WriteLine("Set timer in minutes and seconds(e.g. 12:30)");
string timeToRecall = Console.ReadLine();


//SplitTime(minutesAndSeconds);

int [,] minutesAndSeconds = serivice.SplitTime(timeToRecall);
//var msToMin = 0;
//Console.Clear();

var totalTime = serivice.MinutesAndSecondForTimer(minutesAndSeconds);

Console.WriteLine("Timer starts");

//msToMin = msToMin * 60;//change name? 

serivice.StartTimer(totalTime);
