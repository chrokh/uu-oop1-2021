using System;

namespace Lab2
{
  class GuessTheNumberGame
  {
    public int Min { get; private set; }
    public int Max { get; private set; }
    public GuessTheNumberPlayer CurrentPlayer { get; private set; }
    public GuessTheNumberPlayer Player1 { get; private set; }
    public GuessTheNumberPlayer Player2 { get; private set; }

    public GuessTheNumberGame (int min, int max)
    {
      Min = min;
      Max = max;
      Random rnd = new Random();
      Player1 = new GuessTheNumberPlayer("Player 1", rnd.Next(Min, Max));
      Player2 = new GuessTheNumberPlayer("Player 2", rnd.Next(Min, Max));
      CurrentPlayer = Player1;
    }

    public void Guess (int x)
    {
      if (CurrentPlayer != null)
      {
        CurrentPlayer.Guess(x);
        switchPlayer();
      }
    }

    public bool IsOver()
    {
      return Player1.IsCorrect() && Player2.IsCorrect();
    }

    public bool IsDraw ()
    {
      return IsOver() && Player1.NumGuesses == Player2.NumGuesses;
    }

    public bool HasWinner ()
    {
      return GetWinner() != null;
    }

    public GuessTheNumberPlayer GetWinner ()
    {
      if (IsOver())
        if (Player1.NumGuesses < Player2.NumGuesses)
          return Player1;
        else if (Player2.NumGuesses < Player1.NumGuesses)
          return Player2;
      return null;
    }

    private void switchPlayer ()
    {
      if (CurrentPlayer == Player1 && !Player2.IsCorrect())
        CurrentPlayer = Player2;
      else if (CurrentPlayer == Player2 && !Player1.IsCorrect())
        CurrentPlayer = Player1;
      else if (Player1.IsCorrect() && Player2.IsCorrect())
        CurrentPlayer = null;
    }
  }
}
