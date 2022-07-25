using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int sum = 0;
            int intVal;
            Console.WriteLine("Enter the number:");
            input = Console.ReadLine();
            intVal = Convert.ToInt32(input);
            for (int i = 1; i < intVal; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;
                }
            }

            Console.WriteLine("Sum is " + sum);
        }
    }        
}
    
