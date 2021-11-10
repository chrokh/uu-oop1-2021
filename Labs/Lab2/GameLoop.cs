using System;

namespace Lab2
{
  class GameLoop
  {
    ConsoleGame game;

    public GameLoop (ConsoleGame game)
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
