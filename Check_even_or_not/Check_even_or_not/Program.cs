using System;

namespace Check_even_or_not
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter  a Number : ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("is even" + number);
            }
            else
            {
                Console.WriteLine("is odd" + number);
            }
        }
    }
}
