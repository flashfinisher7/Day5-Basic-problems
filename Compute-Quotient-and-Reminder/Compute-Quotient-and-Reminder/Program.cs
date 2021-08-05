using System;

namespace Compute_Quotient_and_Reminder
{
    class Program
    {
        static void Main(string[] args)
        {
            int divident;
            int divisor;
            int quotient;
            int reminder;
            Console.WriteLine("Enter Dividend : ");
            divident = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor : ");
            divisor = Convert.ToInt32(Console.ReadLine());
            quotient = divident / divisor;
            reminder = divident % divisor;
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + reminder);

        }
    }
}
