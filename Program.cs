using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Convert a string to an integer using TryParse
            Console.Write("Enter an integer: ");
            string intStr = Console.ReadLine();
            int parsedInt;

            if (int.TryParse(intStr, out parsedInt))
            {
                int result = parsedInt * 5;
                Console.WriteLine($"Parsed and multiplied by 5: {result}");
            }
            else
            {
                Console.WriteLine("Invalid input. Not an integer.");
            }

            // Convert a string to a DateTime object using Convert
            Console.Write("Enter a date (MM/dd/yyyy): ");
            string dateStr = Console.ReadLine();

            try
            {
                DateTime convertedDate = Convert.ToDateTime(dateStr);
                DateTime subtractedDate = convertedDate.AddMonths(-1);
                Console.WriteLine($"Converted date: {convertedDate:MM/dd/yyyy}");
                Console.WriteLine($"Subtracted 1 month: {subtractedDate:MM/dd/yyyy}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Not a valid date format.");
            }

            // Convert a string to a TimeSpan object using Parse
            Console.Write("Enter a time (hh:mm:ss): ");
            string timeStr = Console.ReadLine();

            try
            {
                TimeSpan parsedTime = TimeSpan.Parse(timeStr);
                TimeSpan resultTime = parsedTime.Add(new TimeSpan(2, 0, 0));
                Console.WriteLine($"Parsed time: {parsedTime}");
                Console.WriteLine($"Added 2 hours: {resultTime}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Not a valid time format.");
            }
        }
    }
}
