namespace Lab2
{
  class TicTacToeConsoleGameFactory : ConsoleGameFactory
  {
    public ConsoleGame MakeConsoleGame ()
    {
      return new TicTacToeConsoleGame(new TicTacToeGame());
    }
  }
}

