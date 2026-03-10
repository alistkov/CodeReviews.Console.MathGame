Console.WriteLine("Welcome to the Math game!");
Console.WriteLine("Enter your name:");

var name = Console.ReadLine();
var date = DateTime.UtcNow;

Console.WriteLine("==========================");
Console.WriteLine($"Hello, {name}! It's {date.DayOfWeek}. Let's play Math Game!");
Console.WriteLine(@"What game would you like to play today?
1 - Addition
2 - Subtraction
3 - Multiplication
4 - Division
0 - Exit");
Console.WriteLine("==========================");

var userSelection = int.Parse(Console.ReadLine());
Console.WriteLine(userSelection);
