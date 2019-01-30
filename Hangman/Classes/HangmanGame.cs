using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman.Classes
{
    class HangmanGame
    {
        public string HangmanWord { get; set; }
        public string GuessAttempt { get; set; }
        public List<string> Guesses { get; set; }

        public HangmanGame()
        {
            this.Guesses = new List<string>();
        }

        public void Play()
        {
            Console.Clear();
            Console.WriteLine("Player One, input a word or phrase. Player Two NO PEEKING: ");
            this.HangmanWord = Console.ReadLine();
            string formattedWord;

            while (true)
            {
                Console.Clear();
                this.HangmanArt(this.Guesses.Count);
                Console.WriteLine($"Hangman Word: {this.FormatWord()}");
                Console.Write("Player Two, what is your next guess: ");

                this.GuessAttempt = this.GetGuess();
            }
        }

        private string GetGuess()
        {
            string output = "";
            bool validGuess = false;

            do
            {
                output = Console.ReadLine();
                if (output.Length > 1)
                {
                    Console.WriteLine("Nice try. You can only guess 1 letter at a time");
                }
                else if (output.Length < 1)
                {
                    Console.WriteLine("You have to guess something!");
                }
                else
                {
                    validGuess = true;
                }

            } while (!validGuess);

            this.Guesses.Add(output);
            return output;
        }

        public void Greeting()
        {
            Console.WriteLine("Welcome to Hangman");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Rules:");
            Console.WriteLine("This is a two player game. Player One will input a word");
            Console.WriteLine("and Player Two will guess letters in attempts to figure");
            Console.WriteLine("out what Player One entered. After the word is guessed,");
            Console.WriteLine("Player Two will be graded based on how well they performed.");
            Console.WriteLine();
            Console.WriteLine("Ready to Play? (press Enter to Continue)");
            Console.ReadLine();
        }

        public string FormatWord()
        {
            string word = "";

            for (int i = 0; i < this.HangmanWord.Length; i++)
            {
                bool guessed = false;

                if (this.HangmanWord[i].ToString() == " ")
                {
                    word += "  ";
                    continue;
                }
                foreach (string guess in this.Guesses)
                {
                    if (this.HangmanWord[i].ToString() == guess)
                    {
                        guessed = true;
                        word += guess.ToUpper() + " ";
                    }
                }
                if (guessed)
                {
                    continue;
                }
                else
                {
                    word += "_ ";
                }
            }

            return word;
        }

        public void HangmanArt(int guesses)
        {
            switch (guesses)
            {
                case 0:
                    Console.WriteLine(@"        _____        ");
                    Console.WriteLine(@"       |    |        ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"    ___|_________    ");
                    Console.WriteLine(@"                     ");
                    break;
                case 1:
                    Console.WriteLine(@"        _____        ");
                    Console.WriteLine(@"       |    |        ");
                    Console.WriteLine(@"       |    (        ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"    ___|_________    ");
                    Console.WriteLine(@"                     ");
                    break;
                case 2:
                    Console.WriteLine(@"        _____        ");
                    Console.WriteLine(@"       |    |        ");
                    Console.WriteLine(@"       |    ()       ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"    ___|_________    ");
                    Console.WriteLine(@"                     ");
                    break;
                case 3:
                    Console.WriteLine(@"        _____        ");
                    Console.WriteLine(@"       |    |        ");
                    Console.WriteLine(@"       |    ()       ");
                    Console.WriteLine(@"       |    |        ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"    ___|_________    ");
                    Console.WriteLine(@"                     ");
                    break;
                case 4:
                    Console.WriteLine(@"        _____        ");
                    Console.WriteLine(@"       |    |        ");
                    Console.WriteLine(@"       |    ()       ");
                    Console.WriteLine(@"       |   \|        ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"    ___|_________    ");
                    Console.WriteLine(@"                     ");
                    break;
                case 5:
                    Console.WriteLine(@"        _____        ");
                    Console.WriteLine(@"       |    |        ");
                    Console.WriteLine(@"       |    ()       ");
                    Console.WriteLine(@"       |   \|/       ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"    ___|_________    ");
                    Console.WriteLine(@"                     ");
                    break;
                case 6:
                    Console.WriteLine(@"        _____        ");
                    Console.WriteLine(@"       |    |        ");
                    Console.WriteLine(@"       |    ()       ");
                    Console.WriteLine(@"       |   \|/       ");
                    Console.WriteLine(@"       |    |        ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"    ___|_________    ");
                    Console.WriteLine(@"                     ");
                    break;
                case 7:
                    Console.WriteLine(@"        _____        ");
                    Console.WriteLine(@"       |    |        ");
                    Console.WriteLine(@"       |    ()       ");
                    Console.WriteLine(@"       |   \|/       ");
                    Console.WriteLine(@"       |    |        ");
                    Console.WriteLine(@"       |   /         ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"    ___|_________    ");
                    Console.WriteLine(@"                     ");
                    break;
                case 8:
                    Console.WriteLine(@"        _____        ");
                    Console.WriteLine(@"       |    |        ");
                    Console.WriteLine(@"       |    ()       ");
                    Console.WriteLine(@"       |   \|/       ");
                    Console.WriteLine(@"       |    |        ");
                    Console.WriteLine(@"       |   /\        ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"       |             ");
                    Console.WriteLine(@"    ___|_________    ");
                    Console.WriteLine(@"                     ");
                    break;
            }
        }
    }
}
