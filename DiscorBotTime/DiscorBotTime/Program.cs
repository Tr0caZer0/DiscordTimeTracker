// See https://aka.ms/new-console-template for more information
using DiscorBotTime;

Console.WriteLine("Set timer (in minutes)");
var timeToRecall = Console.ReadLine();
var msToMin = int.Parse(timeToRecall);
Console.Clear();
Console.WriteLine("Timer starts");

msToMin = msToMin * 60;//change name? 


var serivice = new TimerService();

serivice.StartTimer(msToMin);
