using System;
using System.Collections.Generic;

namespace Calendar
{
    class Program
    {
        static void Main()
        {
            Calendar calendar = new Calendar();
            calendar.PrintCalendar();

            List<TimeSpan> timeSpans = new List<TimeSpan>
            {
                new TimeSpan(2, 2, 2, 2),
                new TimeSpan(6, 7, 2, 3),
                new TimeSpan(3, 5, 1, 8),
                new TimeSpan(4, 1, 4, 2)
            };

            foreach(TimeSpan time in timeSpans)
            {
                Console.WriteLine("\n");
                calendar.DateShifting(time);
                calendar.PrintCalendar();
            }

            Console.ReadKey();
        }
    }
}
