using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Str1;
            string Str2;
            Console.WriteLine("Enter string1:");
            Str1 = Console.ReadLine();
            Console.WriteLine("Enter string2:");
            Str2 = Console.ReadLine();
            for (int i = 0; i <= Str1.Length - Str2.Length; i++)
            {
                string subStr = Str1.Substring(i, Str2.Length);
                if (subStr == Str2)
                {
                    Console.WriteLine("Index is " + i);
                    break;
                }
            }
            
        }
    }        
}
    
