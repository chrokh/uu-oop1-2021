using System;

namespace Lab2
{
  class Program
  {
    public record Person(string FirstName, string LastName);

    static void Main(string[] args)
    {
      // Example of setting up multi game
      ConsoleGame multi
        = new MultiConsoleGame(
            new TicTacToeConsoleGame(new InvertedTicTacToeGame()),
            new TicTacToeConsoleGame(new TicTacToeGame()));

      // Example of setting up eternal game
      ConsoleGame eternal
        = new EternalConsoleGame(new GuessTheNumberConsoleGameFactory(1, 3));

      // Example of setting up parallel game
      ConsoleGame parallel
        = new ParallelConsoleGame(
            new TicTacToeConsoleGame(new TicTacToeGame()),
            new TicTacToeConsoleGame(new InvertedTicTacToeGame()));

      // Example of setting up loop for one of the games
      GameLoop loop = new GameLoop(parallel);

      loop.Start();
    }
  }
}
