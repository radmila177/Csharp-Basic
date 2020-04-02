using System;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime daysNow = DateTime.Now;
            DateTime addDays = daysNow.AddDays(3);
            DateTime addMonths = daysNow.AddMonths(1);
            DateTime addMonthsAndDays = daysNow.AddMonths(1).AddDays(3);
            DateTime yearsAndMonthsAgo = daysNow.AddYears(-1).AddMonths(-2);
            int currentMonth = daysNow.Month;
            int currentYear = daysNow.Year;

            Console.WriteLine($"The date now is: {daysNow}");
            Console.WriteLine($"The date that is 3 days from now is: {addDays}");
            Console.WriteLine($"The date that is one month from now is: {addMonths}");
            Console.WriteLine($"The date that is one month and 3 days from now is: {addMonthsAndDays}");
            Console.WriteLine($"1 year and 2 months ago from today: {yearsAndMonthsAgo}");
            Console.WriteLine($"The current month of today is: {currentMonth}");
            Console.WriteLine($"The current year of today is: {currentYear}");

            Console.ReadLine();
        }
    }
}
