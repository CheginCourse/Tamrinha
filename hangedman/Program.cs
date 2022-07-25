using System;
using hangman;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 'Enter' for start...");
            Console.ReadLine();
            var hangman = new Hangman(){chances=6};
            string[] words= {"access", "data", "hand", "foot", "word", "letter"};
            string word = hangman.RandomChoice(words);
            for (; hangman.chances > 1; )
            {
                Console.WriteLine("\n" + hangman.ShowResult());
                if (hangman.win)
                {
                    return;
                }
                Console.WriteLine("Enter letter:");
                char letter = Convert.ToChar(Console.ReadLine());
                hangman.CheckChar(letter, 0);
                hangman.CheckWin();
            }
            Console.WriteLine("You lost...");
           
        }
    }
}

