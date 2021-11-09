using System;

namespace Lab1
{
  class Program
  {
    static void Main(string[] args)
    {
      TicTacToeConsoleGame game = new TicTacToeConsoleGame(new TicTacToeGame());
      GameLoop loop = new GameLoop(game);
      loop.Start();

    }
  }
}
