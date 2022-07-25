using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNum;
            string Char;
            int Repeat = 0;
            Console.WriteLine("Enter big number:");
            bigNum = Console.ReadLine();
            Console.WriteLine("Enter character:");
            Char = Console.ReadLine();
            for (int i = 0; i < bigNum.Length; i++)
            {
                if (Char == Convert.ToString(bigNum[i]))
                {
                    Repeat = Repeat + 1;
                }
            }

            Console.WriteLine("Repeat is " + Repeat);
        }
    }        
}
    
