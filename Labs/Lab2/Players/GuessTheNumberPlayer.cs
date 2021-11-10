namespace Lab2
{
  class GuessTheNumberPlayer
  {
    public string Name { get; private set; }
    public int NumGuesses { get; private set; }
    public int LastGuess { get; private set; }
    public bool HasGuessed { get; private set; }
    public string Hint { get; private set; }
    int secretNumber;

    public GuessTheNumberPlayer (string name, int secretNumber)
    {
      Name = name;
      this.secretNumber = secretNumber;

      HasGuessed = false;
    }

    public void Guess (int guess)
    {
      HasGuessed = true;
      NumGuesses++;
      LastGuess = guess;
      if (LastGuess > secretNumber)
        Hint = "too high";
      else if (LastGuess < secretNumber)
        Hint = "too low";
      else
        Hint = "correct";
    }

    public bool IsCorrect ()
    {
      return secretNumber == LastGuess && HasGuessed;
    }
  }
}
