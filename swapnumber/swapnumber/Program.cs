using System;

namespace swapnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstnumber;
            double secondnumber;
            double temp;
            Console.WriteLine("Enter First Number and Second Number ");
            firstnumber = Convert.ToInt32(Console.ReadLine());
            secondnumber = Convert.ToInt32(Console.ReadLine());
            temp = firstnumber;
            firstnumber = secondnumber;
            secondnumber = temp;
            Console.WriteLine("After swapping First number : " + firstnumber);
            Console.WriteLine("After swapping Second number : " + secondnumber);
        }
    }
}
