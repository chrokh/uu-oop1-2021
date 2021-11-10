using System;

namespace Lab2
{
  class GuessTheNumberConsoleGame : ConsoleGame
  {
    GuessTheNumberGame game;
    string errorMessage = "";
    bool isOver = false;

    public GuessTheNumberConsoleGame (int min, int max)
    {
      this.game = new GuessTheNumberGame (min, max);
    }

    public bool IsOver ()
    {
      return isOver;
    }

    public void Print ()
    {
      Console.WriteLine($"I'm thinking of numbers between {game.Min} and {game.Max}.");
      Console.WriteLine("Can you guess what your number is?");
      Console.WriteLine();

      printPlayerStatus(game.Player1);
      printPlayerStatus(game.Player2);
      Console.WriteLine();

      if (game.HasWinner())
      {
        Console.WriteLine($"{game.GetWinner().Name} has won the game!");
        Console.WriteLine("Press ENTER to continue.");
      }
      else if (game.IsDraw())
      {
        Console.WriteLine("Draw!");
        Console.WriteLine("Press ENTER to continue.");
      }
      else
      {
        if (errorMessage != "")
        {
          Console.WriteLine(errorMessage);
          Console.WriteLine();
        }

        Console.WriteLine($"{game.CurrentPlayer.Name}, type your guess and press ENTER.");
      }
    }

    public void HandleInput (string input)
    {
      if (game.IsOver())
      {
        isOver = true;
      }
      else
      {
        errorMessage = ""; // Reset error message
        int number;
        if(Int32.TryParse(input, out number))
          game.Guess(number);
        else
          errorMessage = "Please type a number a try again!";
      }
    }

    private void printPlayerStatus (GuessTheNumberPlayer player)
    {
      if (player.HasGuessed)
        Console.WriteLine($"{player.Name} has guessed {player.NumGuesses} times and the last guess was {player.Hint} ({player.LastGuess}).");
      else
        Console.WriteLine($"{player.Name} has not yet guessed.");
    }
  }
}
