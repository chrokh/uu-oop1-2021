namespace Lab2
{
  class InvertedTicTacToeConsoleGameFactory : ConsoleGameFactory
  {
    public ConsoleGame MakeConsoleGame ()
    {
      return new TicTacToeConsoleGame(
          new InvertedTicTacToeGame());
    }
  }
}

