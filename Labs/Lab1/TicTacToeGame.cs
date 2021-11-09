namespace Lab1
{
  class TicTacToeGame
  {
    public Player CurrentPlayer { get; private set; }

    Player NW;
    Player NC;
    Player NE;
    Player MW;
    Player MC;
    Player ME;
    Player SW;
    Player SC;
    Player SE;

    Player p1;
    Player p2;

    public TicTacToeGame ()
    {
      this.p1 = new Player('X');
      this.p2 = new Player('O');
      CurrentPlayer = p1;
    }

    public void PlayNW () { NW = CurrentPlayer; switchPlayer(); }
    public void PlayNC () { NC = CurrentPlayer; switchPlayer(); }
    public void PlayNE () { NE = CurrentPlayer; switchPlayer(); }
    public void PlayMW () { MW = CurrentPlayer; switchPlayer(); }
    public void PlayMC () { MC = CurrentPlayer; switchPlayer(); }
    public void PlayME () { ME = CurrentPlayer; switchPlayer(); }
    public void PlaySW () { SW = CurrentPlayer; switchPlayer(); }
    public void PlaySC () { SC = CurrentPlayer; switchPlayer(); }
    public void PlaySE () { SE = CurrentPlayer; switchPlayer(); }

    public bool CanPlayNW () { return NW == null; }
    public bool CanPlayNC () { return NC == null; }
    public bool CanPlayNE () { return NE == null; }
    public bool CanPlayMW () { return MW == null; }
    public bool CanPlayMC () { return MC == null; }
    public bool CanPlayME () { return ME == null; }
    public bool CanPlaySW () { return SW == null; }
    public bool CanPlaySC () { return SC == null; }
    public bool CanPlaySE () { return SE == null; }

    public Player PlayerAtNW () { return NW; }
    public Player PlayerAtNC () { return NC; }
    public Player PlayerAtNE () { return NE; }
    public Player PlayerAtMW () { return MW; }
    public Player PlayerAtMC () { return MC; }
    public Player PlayerAtME () { return ME; }
    public Player PlayerAtSW () { return SW; }
    public Player PlayerAtSC () { return SC; }
    public Player PlayerAtSE () { return SE; }

    public bool IsDraw ()
    {
      return !HasWinner()
        && NW != null
        && NC != null
        && NE != null
        && MW != null
        && MC != null
        && ME != null
        && SW != null
        && SC != null
        && SE != null;
    }


    public bool HasWinner ()
    {
      return GetWinner() != null;
    }

    public Player GetWinner ()
    {
      // Rows
      if (NW == NC && NW == NE) return NW;
      if (MW == MC && MW == ME) return MW;
      if (SW == SC && SW == SE) return SW;

      // Cols
      if (NW == MW && NW == SW) return NW;
      if (NC == MC && NC == SC) return NC;
      if (NE == ME && NE == SE) return NE;

      // Diagonals
      if (NW == MC && NW == SE) return NW;
      if (NE == MC && NE == SW) return NE;

      return null;
    }

    private void switchPlayer ()
    {
      if (CurrentPlayer == p1)
        CurrentPlayer = p2;
      else
        CurrentPlayer = p1;
    }
  }
}
