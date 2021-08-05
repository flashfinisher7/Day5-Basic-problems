using System;

namespace harmonic
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            Console.WriteLine("Enter Harmonic Number");
            Num = Convert.ToInt32(Console.ReadLine());
            double HarmNum = 0;
            for (int i = 1; i < Num; i++)
            {
                HarmNum += (double)1 / i;
                Console.WriteLine("Harmonic Number is " + HarmNum);
            }
        }
    }
}
