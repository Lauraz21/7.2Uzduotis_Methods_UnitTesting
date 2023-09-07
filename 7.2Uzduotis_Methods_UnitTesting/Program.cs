using System;

namespace _7._2Uzduotis_Methods_UnitTesting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("convert to euros");
            float userInput = Convert.ToSingle(Console.ReadLine());

            float sum = ConvertToEuros(userInput);
            Console.WriteLine($" {sum} Eur.");
        }

        public static float ConvertToEuros(float dollars)
        {
            return dollars * 0.85f;
        }
    }
}