using DiscorBotTime;

Console.WriteLine("Set timer in minutes and seconds(e.g. 12:30)");
// Takes user input and cals on SplitTime method to create array of integers.
var minutesAndSeconds = ConvertInput.SplitTime(Console.ReadLine());

// calls on MinutesAndSecondsForTimer method taking array from SplitTime method
var totalTime = ConvertInput.MinutesAndSecondForTimer(minutesAndSeconds);

TimerService.gotResponse = false;
Console.WriteLine("Timer starts");

var countdownThread = new Thread(() => TimerService.StartTimer(totalTime));
countdownThread.Start();

var response = Console.ReadLine();
TimerService.gotResponse= true;

// Wait for the countdown thread to complete
countdownThread.Join();
