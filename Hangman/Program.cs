using System;
using Hangman.Classes;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            HangmanGame game = new HangmanGame();
            game.Greeting();
            game.Play();
        }
    }
}
