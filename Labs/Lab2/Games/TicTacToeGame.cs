namespace Lab2
{
  class TicTacToeGame
  {
    public TicTacToePlayer CurrentPlayer { get; private set; }

    private TicTacToePlayer NW;
    private TicTacToePlayer NC;
    private TicTacToePlayer NE;
    private TicTacToePlayer MW;
    private TicTacToePlayer MC;
    private TicTacToePlayer ME;
    private TicTacToePlayer SW;
    private TicTacToePlayer SC;
    private TicTacToePlayer SE;

    TicTacToePlayer p1;
    TicTacToePlayer p2;

    public TicTacToeGame ()
    {
      this.p1 = new TicTacToePlayer('X');
      this.p2 = new TicTacToePlayer('O');
      CurrentPlayer = p1;
    }

    public virtual void PlayNW () { if (NW == null) NW = CurrentPlayer; switchPlayer(); }
    public virtual void PlayNC () { if (NC == null) NC = CurrentPlayer; switchPlayer(); }
    public virtual void PlayNE () { if (NE == null) NE = CurrentPlayer; switchPlayer(); }
    public virtual void PlayMW () { if (MW == null) MW = CurrentPlayer; switchPlayer(); }
    public virtual void PlayMC () { if (MC == null) MC = CurrentPlayer; switchPlayer(); }
    public virtual void PlayME () { if (ME == null) ME = CurrentPlayer; switchPlayer(); }
    public virtual void PlaySW () { if (SW == null) SW = CurrentPlayer; switchPlayer(); }
    public virtual void PlaySC () { if (SC == null) SC = CurrentPlayer; switchPlayer(); }
    public virtual void PlaySE () { if (SE == null) SE = CurrentPlayer; switchPlayer(); }

    public virtual bool CanPlayNW () { return NW == null; }
    public virtual bool CanPlayNC () { return NC == null; }
    public virtual bool CanPlayNE () { return NE == null; }
    public virtual bool CanPlayMW () { return MW == null; }
    public virtual bool CanPlayMC () { return MC == null; }
    public virtual bool CanPlayME () { return ME == null; }
    public virtual bool CanPlaySW () { return SW == null; }
    public virtual bool CanPlaySC () { return SC == null; }
    public virtual bool CanPlaySE () { return SE == null; }

    public virtual TicTacToePlayer PlayerAtNW () { return NW; }
    public virtual TicTacToePlayer PlayerAtNC () { return NC; }
    public virtual TicTacToePlayer PlayerAtNE () { return NE; }
    public virtual TicTacToePlayer PlayerAtMW () { return MW; }
    public virtual TicTacToePlayer PlayerAtMC () { return MC; }
    public virtual TicTacToePlayer PlayerAtME () { return ME; }
    public virtual TicTacToePlayer PlayerAtSW () { return SW; }
    public virtual TicTacToePlayer PlayerAtSC () { return SC; }
    public virtual TicTacToePlayer PlayerAtSE () { return SE; }

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

    public TicTacToePlayer GetWinner ()
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
