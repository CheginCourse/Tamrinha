using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int number = Convert.ToInt32(Console.ReadLine());
            string result = Binary(number);

            Console.WriteLine("Result is " + result);
        }
        
        public static string Binary(int number){
            if (number/2 == 1)
            {
                return $"{number/2}{number%2}";
            }

           return  Binary(number/2) + $"{number%2}";
        }
    }
}

