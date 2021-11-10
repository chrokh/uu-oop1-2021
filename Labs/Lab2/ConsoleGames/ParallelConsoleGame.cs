using System;

namespace Lab2
{
  class ParallelConsoleGame : ConsoleGame
  {
    ConsoleGame game1;
    ConsoleGame game2;

    public ParallelConsoleGame (ConsoleGame game1, ConsoleGame game2)
    {
      this.game1 = game1;
      this.game2 = game2;
    }

    public bool IsOver ()
    {
      return game1.IsOver() && game2.IsOver();
    }

    public void Print ()
    {
      Console.WriteLine("========== GAME 1 ==========");
      game1.Print();
      Console.WriteLine("========== GAME 2 ==========");
      game2.Print();
      Console.WriteLine("============================");
    }

    public void HandleInput (string input)
    {
      if (!game1.IsOver())
        game1.HandleInput(input);
      if (!game2.IsOver())
        game2.HandleInput(input);
    }
  }
}

