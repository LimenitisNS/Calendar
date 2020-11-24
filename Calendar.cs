using System;

namespace Calendar
{
    public class Calendar
    {
        public DateTime currentTime = DateTime.Now;

        public void DateShifting(TimeSpan timeSpan)
        {
            currentTime += timeSpan;
        }

        public void PrintCalendar()
        {
            DateTime weekday;
            bool firstIteration = true;

            Console.WriteLine($"{currentTime.Year}\n{currentTime.ToString("MMMMMMMM")}\nПн\tВт\tСр\tЧт\tПт\tСб\tВс");

            for (int day = 1; day <= DateTime.DaysInMonth(currentTime.Year, currentTime.Month); ++day)
            {
                weekday = new DateTime(currentTime.Year, currentTime.Month, day);

                if (firstIteration)
                {
                    if (weekday.DayOfWeek == DayOfWeek.Sunday)
                    {
                        for (int firstDay = 5; firstDay >= 0; --firstDay)
                        {
                            Console.Write("\t");
                        }
                    }
                    else
                    {
                        for (int firstDay = (int)weekday.DayOfWeek - 1; firstDay > 0; --firstDay)
                        {
                            Console.Write("\t");
                        }
                    }
                    firstIteration = false;
                }

                if(weekday.Day == currentTime.Day || weekday.DayOfWeek == DayOfWeek.Saturday || weekday.DayOfWeek == DayOfWeek.Sunday)
                {
                    if (weekday.Day == currentTime.Day)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write((int)weekday.Day + "\t");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write((int)weekday.Day + "\t");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.Write((int)weekday.Day + "\t");
                }

                if (weekday.DayOfWeek == DayOfWeek.Sunday)
                {
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
