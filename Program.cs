
using System.Globalization;
///Get Current Month and year ^^
var month = int.Parse( DateTime.Now.ToString("MM"));
var FullMonth = DateTime.Now.ToString("MMMM");


var FinalMonth = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month + 1);
var year = int.Parse( DateTime.Now.ToString("yyyy"));
var weeknum = DateTime.Now.DayOfWeek;

var today = DateTime.Now.Day;



Console.WriteLine("===============");

/// Get Days In Current Month
var daysInmonth = DateTime.DaysInMonth(year, month);



var Leftdays = 0;


for (int i = 1; i < 13; i++)
{
    ///Green Arrow
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("[→] ");
    Console.ForegroundColor = ConsoleColor.White;


    string name = DateTimeFormatInfo.CurrentInfo.GetMonthName(i);
    Console.Write($"{name } Has " );


    var FullDaysInMonth = DateTime.DaysInMonth(year, i);
    Console.WriteLine($"{FullDaysInMonth} Days");


    var daysLeft = FullDaysInMonth - today;

    Leftdays = daysLeft;
}


Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("╔══════════════════════════════════════╗");
Console.WriteLine("║++++++++++++++++++++++++++++++++++++++║ ");
Console.WriteLine("╚══════════════════════════════════════╝ ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();

var fullDays = DateTime.DaysInMonth(year, month);

for (int i = 1; i < fullDays+1; i++)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("[→] ");
    Console.ForegroundColor = ConsoleColor.White;


    DateTime dateValue = new DateTime(year, month, i);
    var WeekDayFull = dateValue.ToString("dddd");


    Console.WriteLine($"{i} {FullMonth} is {WeekDayFull}");



}


Console.WriteLine();
// Red cross
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("[+] ");
Console.ForegroundColor = ConsoleColor.White;


Console.WriteLine($"{Leftdays} Days Till {FullMonth} Ends");




Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("▄▀█ █▀█ █▀█   █▀▄▀█ ▄▀█ █▀▄ █▀▀   █▄▄ █▄█   █░░ ▄▀█ █▀ █░█ █░█ ▄▀█ █▀█ █▀▄ █");
Console.WriteLine("█▀█ █▀▀ █▀▀   █░▀░█ █▀█ █▄▀ ██▄   █▄█ ░█░   █▄▄ █▀█ ▄█ █▀█ ▀▄▀ █▀█ █▀▄ █▄▀ █");

Console.ForegroundColor = ConsoleColor.White;

Console.ReadKey();





