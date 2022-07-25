using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 5;
            for (int i = 1; i < length + 1; i++)
            {
                string result = "";
                result = result + String.Concat(Enumerable.Repeat(" ", length - i));
                for (int c = 1; c < i + 1; c++)
                {
                    result = result + c;
                }
                for (int j = i - 1; j > 0; j--)
                {
                    result = result + j;
                }
                result = result + String.Concat(Enumerable.Repeat(" ", length - i));
                Console.WriteLine(result);
            } 
        }
    }        
}
    
