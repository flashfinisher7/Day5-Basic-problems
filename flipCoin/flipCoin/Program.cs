using System;

namespace flipCoin
{
    class Program
    {
        static double FindpercentageofHeads(int numberofTimesCoinTossed)
        {
            Random rand = new Random();
            double headCount = 0;
            int HEADS = 1;

            for (int i = 0; i< numberofTimesCoinTossed; i++)
            {
                int coinTossed = rand.Next(0, 2);

            }
            Console.WriteLine("Hello World!");
            static double FindpercentofTails(double headspercentage)
            static void Main(string[] args)
            {
                Console.WriteLine("Enter Number of times coin should be Tossed");
                int numberofTimesCoinTossed = int.Parse(Console.ReadLine());
                double headpercentage = FindpercentageofHeads(numberofTimesCoinTossed);
                double tailspercentage = FindpercentageofTails(headpercentage);
                Console.WriteLine("Head Percentage : " + headpercentage);
                Console.WriteLine("Tails Percentage : " + tailspercentage);
            }
    }
}
