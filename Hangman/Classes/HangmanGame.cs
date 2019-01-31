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
        public int WrongGuessCount { get; private set; }
        public List<string> validChars { get; }

        public HangmanGame()
        {
            this.Guesses = new List<string>();
            this.WrongGuessCount = 0;
            this.validChars = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

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

        public void Play()
        {
            Console.Clear();
            Console.WriteLine("Player One, input a word or phrase. Player Two NO PEEKING: ");
            this.HangmanWord = Console.ReadLine().ToLower();

            while (true)
            {
                Console.Clear();
                this.HangmanArt(this.WrongGuessCount);
                Console.WriteLine($"Hangman Word: {this.FormatWord()}");
                Console.WriteLine($"Previous Guesses: {this.DisplayGuesses()}");
                Console.Write("Player Two, what is your next guess: ");

                this.GuessAttempt = this.GetGuess();

                if (!this.HangmanWord.Contains(this.GuessAttempt))
                {
                    this.WrongGuessCount++;
                }
                else if (!this.FormatWord().Contains('_'))
                {
                    break;
                }
            }
        }

        public void EndGame()
        { 
            Console.Clear();
            this.HangmanArt(this.WrongGuessCount);
            Console.WriteLine($"Hangman Word: {this.FormatWord()}");
            Console.WriteLine($"Previous Guesses: {this.DisplayGuesses()}");
            Console.WriteLine();
            Console.WriteLine($"The word has been discovered. It took you {this.Guesses.Count} guesses.");
            Console.WriteLine($"You didn't guess a correct letter {this.WrongGuessCount} times.");
            Console.WriteLine();
            Console.ReadLine();
        }

        private string GetGuess()
        {
            string output = "";
            bool validGuess = false;

            do
            {
                output = Console.ReadLine().ToLower();

                if (output.Length > 1)
                {
                    Console.Write("Nice try. You can only guess 1 letter at a time. Try again: ");
                }
                else if (output.Length < 1)
                {
                    Console.Write("You have to guess something! Try again: ");
                }
                else
                {
                    validGuess = true;
                }

                if (this.Guesses.Contains(output))
                {
                    Console.Write("You've already guessed that! Go ahead and try again:");
                    validGuess = false;
                    continue;
                }

                if (!this.validChars.Contains(output))
                {
                    Console.Write("Punctuation/Numbers have already been added. Try again: ");
                    validGuess = false;
                    continue;
                }

            } while (!validGuess);

            this.Guesses.Add(output);
            return output;
        }

        public string FormatWord()
        {
            string word = "";

            for (int i = 0; i < this.HangmanWord.Length; i++)
            {
                bool guessed = false;

                if (!this.validChars.Contains(this.HangmanWord[i].ToString()))
                {
                    word += this.HangmanWord[i] + " ";
                    continue;
                }
                foreach (string guess in this.Guesses)
                {
                    if (this.HangmanWord[i].ToString() == guess)
                    {
                        guessed = true;
                        word += guess.ToUpper() + " ";
                        break;
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
                default:
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

        public string DisplayGuesses()
        {
            string output = "";
            this.Guesses.Sort();

            foreach (string letter in this.Guesses)
            {
                output += (letter + ", ");
            }

            return output.Trim(',');
        }
    }
}
