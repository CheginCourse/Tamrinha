using System;
using other;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of persons:");
            int count = Convert.ToInt32(Console.ReadLine());
            for (; count > 0; count--)
            {
                Console.WriteLine($"Enter name, haghozahme, saat kar for person{count}:");
                string personName = Console.ReadLine();
                int haghozahme = Convert.ToInt32(Console.ReadLine());
                int saatKar = Convert.ToInt32(Console.ReadLine());
                var person = new Person();
                int dailyIncome = person.CalculateDaily(haghozahme, saatKar);
                int income = person.CalculateMonthly(dailyIncome);
                Console.WriteLine("income is "+ income);
            }
        }
    }
}

