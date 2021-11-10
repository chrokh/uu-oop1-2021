using System;

namespace Lab2
{
  class TicTacToeConsoleGame : ConsoleGame
  {
    TicTacToeGame game;
    string errorMessage = "";
    bool isOver = false;

    public TicTacToeConsoleGame (TicTacToeGame game)
    {
      this.game = game;
    }

    public bool IsOver ()
    {
      return isOver;
    }

    public void Print ()
    {
      // Print board
      if (game.PlayerAtNW() != null)
        Console.Write(game.PlayerAtNW().Name + " ");
      else
        Console.Write("* ");

      if (game.PlayerAtNC() != null)
        Console.Write(game.PlayerAtNC().Name + " ");
      else
        Console.Write("* ");

      if (game.PlayerAtNE() != null)
        Console.Write(game.PlayerAtNE().Name + " ");
      else
        Console.Write("* ");

      Console.WriteLine();

      if (game.PlayerAtMW() != null)
        Console.Write(game.PlayerAtMW().Name + " ");
      else
        Console.Write("* ");

      if (game.PlayerAtMC() != null)
        Console.Write(game.PlayerAtMC().Name + " ");
      else
        Console.Write("* ");

      if (game.PlayerAtME() != null)
        Console.Write(game.PlayerAtME().Name + " ");
      else
        Console.Write("* ");

      Console.WriteLine();

      if (game.PlayerAtSW() != null)
        Console.Write(game.PlayerAtSW().Name + " ");
      else
        Console.Write("* ");

      if (game.PlayerAtSC() != null)
        Console.Write(game.PlayerAtSC().Name + " ");
      else
        Console.Write("* ");

      if (game.PlayerAtSE() != null)
        Console.Write(game.PlayerAtSE().Name + " ");
      else
        Console.Write("* ");

      // Line break and empty line
      Console.WriteLine();
      Console.WriteLine();

      // Win screen
      if (game.HasWinner())
      {
        Console.WriteLine($"{game.GetWinner().Name} has won the game!");
        Console.WriteLine("Press ENTER to continue");
      }

      // Draw screen
      else if (game.IsDraw())
      {
        Console.WriteLine("Draw!\r\n");
        Console.WriteLine("Press ENTER to continue.");
      }

      else
      {
        Console.WriteLine($"{game.CurrentPlayer.Name}, it's your turn.");

        if (errorMessage != "")
          Console.WriteLine(errorMessage);

        Console.WriteLine("Type the name of the position you wish to play");
        Console.WriteLine("< NW | NC | NE | MW | MC | ME | SW | SC | SE >");
        Console.WriteLine("and then press ENTER.");
      }
    }

    public void HandleInput (string input)
    {
      // Reset error message.
      errorMessage = "";

      // If game is still going
      if (game.IsDraw() || game.HasWinner())
      {
        isOver = true;
      }
      else
      {
        switch (input)
        {
          case "NW":
            if (game.CanPlayNW())
              game.PlayNW();
            else
              errorMessage = "Position NW is occupied.";
            break;
          case "NC":
            if (game.CanPlayNC())
              game.PlayNC();
            else
              errorMessage = "Position NC is occupied.";
            break;
          case "NE":
            if (game.CanPlayNE())
              game.PlayNE();
            else
              errorMessage = "Position NE is occupied.";
            break;
          case "MW":
            if (game.CanPlayMW())
              game.PlayMW();
            else
              errorMessage = "Position MW is occupied.";
            break;
          case "MC":
            if (game.CanPlayMC())
              game.PlayMC();
            else
              errorMessage = "Position MC is occupied.";
            break;
          case "ME":
            if (game.CanPlayME())
              game.PlayME();
            else
              errorMessage = "Position ME is occupied.";
            break;
          case "SW":
            if (game.CanPlaySW())
              game.PlaySW();
            else
              errorMessage = "Position SW is occupied.";
            break;
          case "SC":
            if (game.CanPlaySC())
              game.PlaySC();
            else
              errorMessage = "Position SC is occupied.";
            break;
          case "SE":
            if (game.CanPlaySE())
              game.PlaySE();
            else
              errorMessage = "Position SE is occupied.";
            break;
          default:
            errorMessage = $"\"{input}\" is not a valid position.";
            break;
        }
      }
    }
  }
}
