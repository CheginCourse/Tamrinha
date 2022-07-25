using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the word:");
            string? word = Console.ReadLine();
            string result = MakeWord(word, (word.Length/2), 0);
             Console.WriteLine(result);
            if(result == word){
                Console.WriteLine("True");
            }
            else{
                Console.WriteLine("False");
            }
        }


        static string MakeWord(string word, int index, int counter){

            if(counter >= index){
                if(word.Length%2 == 0){
                    return "";
                }
                else{
                    return Convert.ToString(word[index]);
                }
            }
            return $"{word[counter]}" + MakeWord(word, index, counter + 1) + $"{word[counter]}";
           
        }
    }
}

