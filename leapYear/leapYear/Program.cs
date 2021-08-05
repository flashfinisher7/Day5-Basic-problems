using System;

namespace leapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year to check leap year or not : ");
            int Year;// = Util.userinputs();
            Year = Convert.ToInt32(Console.ReadLine());
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                Console.WriteLine(Year + " is a Leap Year.");
            }
            else
            {
                Console.WriteLine(Year + " is not a Leap Year.");
            }
        }
    }
}
