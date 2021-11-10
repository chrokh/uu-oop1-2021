using System;

namespace Lab2
{
  class EternalConsoleGame : ConsoleGame
  {
    ConsoleGameFactory factory;
    ConsoleGame current;
    bool betweenGames = true;

    public EternalConsoleGame (ConsoleGameFactory factory)
    {
      this.factory = factory;
    }

    public bool IsOver ()
    {
      return false;
    }

    public void Print ()
    {
      if (betweenGames)
      {
        if (current != null)
        {
          current.Print();
          Console.WriteLine();
        }
        Console.WriteLine("Press ENTER to start new game.");
      }
      else
      {
        current.Print();
      }
    }

    public void HandleInput (string input)
    {
      if (betweenGames)
      {
        current = factory.MakeConsoleGame();
        betweenGames = false;
      }
      else
      {
        current.HandleInput(input);
        if (current.IsOver())
          betweenGames = true;
      }
    }
  }
}

