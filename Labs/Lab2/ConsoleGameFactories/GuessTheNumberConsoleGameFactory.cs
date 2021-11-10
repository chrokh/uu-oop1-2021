namespace Lab2
{
  class GuessTheNumberConsoleGameFactory : ConsoleGameFactory
  {
    int min;
    int max;

    public GuessTheNumberConsoleGameFactory (int min, int max)
    {
      this.min = min;
      this.max = max;
    }

    public ConsoleGame MakeConsoleGame ()
    {
      return new GuessTheNumberConsoleGame(min, max);
    }
  }
}

