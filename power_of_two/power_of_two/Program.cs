using System;

namespace power_of_two
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Required Power Number");
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            int power = 1;
            for (int i = 0; i < number; i++)
            {
                power = power * 2;
            }
            Console.WriteLine("Power of 2 is " + power);
        }
    }
}
