using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int second = Convert.ToInt32(Console.ReadLine());

            int result = Power(first, second);
            Console.WriteLine("Result is" + result);

        }
        
        public static int Power(int first,int second){

            if (second == 1)
            {
                return first;
            }


            return first * Power(first, second-1);
    
        }
    }
}

