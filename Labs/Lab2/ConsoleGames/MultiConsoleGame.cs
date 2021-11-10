using System;

namespace Lab2
{
  class MultiConsoleGame : ConsoleGame
  {
    ConsoleGame game1;
    ConsoleGame game2;

    public MultiConsoleGame (ConsoleGame game1, ConsoleGame game2)
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
      if (!game1.IsOver())
        game1.Print();
      else if (!game2.IsOver())
        game2.Print();
    }

    public void HandleInput (string input)
    {
      if (!game1.IsOver())
        game1.HandleInput(input);
      else if (!game2.IsOver())
        game2.HandleInput(input);
    }
  }
}

