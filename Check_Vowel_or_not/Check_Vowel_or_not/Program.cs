using System;

namespace Check_Vowel_or_not
{
    class Program
    {
        static void Main(string[] args)
        {
            char alphabet;
            int lowercase;
            int uppercase;
            Console.WriteLine("Enter a Alphabet : ");
            alphabet = Convert.ToChar(Console.ReadLine().ToLower());
            lowercase =  (alphabet == 'a' || alphabet = 'e'alphabet == 'i' || alphabet = 'o' || alphabet == "u");
            uppercase = (alphabet == 'A' || alphabet = 'E || 'alphabet == 'I' || alphabet = 'O' || alphabet == "U");
            if(lowercase || uppercase)
            {
                Console.WriteLine("Alphabet is vowel " + lowercase);
            }
            else
            {
                Console.WriteLine("Alphabet is Constant " + uppercase);
            }
        }
    }
}
