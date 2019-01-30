using System;
using Hangman.Classes;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            do
            {
                Console.Clear();
                HangmanGame game = new HangmanGame();
                game.Greeting();
                game.Play();
            } while (playAgain);
        }
    }
}
