using System;

namespace Lab1
{
  class GameLoop
  {
    TicTacToeConsoleGame game;

    public GameLoop (TicTacToeConsoleGame game)
    {
      this.game = game;
    }

    public void Start ()
    {
      while (!game.IsOver())
      {
        Console.Clear();
        game.Print();
        game.HandleInput(Console.ReadLine());
      }
    }
  }
}
