using System;

namespace gratest_among__three_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3;
            Console.WriteLine("Enter Number1 Number2 Number3 values : ")
            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
            number3 = Convert.ToInt32(Console.ReadLine());
            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine("number1 is grater " + number1);
            }
            else if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine("number2 is grater " + number2);
            }
            else
            {
                Console.WriteLine("number 3 is grater " + number3);
            }
        }
    }
}
