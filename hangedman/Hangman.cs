using System;

namespace hangman
{
    class Hangman{

        public int chances{get;set;}
        string? word;

        char[]? result;
        string show = "";

        public bool win = false;

        //# With constructor:

        // public Hangman(int _chances){
        //     chances = _chances;
        // }

        //# With getter & setter:

        // public int Chances{
        //     get{return chances * 2;}
        //     set{chances = value}
        // }

        //# Method for choosing random word:
        public string RandomChoice(string[] randomArray){
            var random = new Random();
            int index = random.Next(randomArray.Length);
            this.word = randomArray[index];
            this.result = String.Concat(Enumerable.Repeat('-', randomArray[index].Length )).ToCharArray();
            return randomArray[index];
        }

        //# Method for showing graphical character:
        public string GraphicalShow(int chances){
            if(chances == 5){
                this.show += "_______\n      O\n";
            } else if(chances == 4){
                this.show += "      |\n";
            } else if(chances == 3){
                this.show += "     /|\\" + "\n";
            } else if(chances == 2){
                this.show += "      |\n";
            } else {
                this.show += "     / \\\n";
            }
            return this.show;
        }
        
        //# Method for checking existance of char:
        public void CheckChar(char letter, int counter){
            for (int i = 0; i < this.word.Length; i++)
            {
                if (letter == this.word[i])
                {
                    this.result[i] = letter;
                }
                else{
                    counter += 1;
                }
            }
            Console.WriteLine(counter);
            if (counter == this.word.Length )
            {
                this.chances -= 1;
                Console.WriteLine(GraphicalShow(this.chances));
            }
        }

        //# Method for checking if user win:
        public void CheckWin(){
            if (this.chances >= 0)
            {
                string check = String.Concat(this.result);
                if (check == this.word)
                {
                    this.win = true;
                    Console.WriteLine("You win");                    
                }
            }
        }

        //# Method for showing guessed word of user:
        public string ShowResult(){
            string show = String.Concat(this.result);
            return show;
        }

    }
}