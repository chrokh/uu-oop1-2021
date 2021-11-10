namespace Lab2
{
  class TicTacToeGame
  {
    public Player CurrentPlayer { get; private set; }

    private Player NW;
    private Player NC;
    private Player NE;
    private Player MW;
    private Player MC;
    private Player ME;
    private Player SW;
    private Player SC;
    private Player SE;

    Player p1;
    Player p2;

    public TicTacToeGame ()
    {
      this.p1 = new Player('X');
      this.p2 = new Player('O');
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

    public virtual Player PlayerAtNW () { return NW; }
    public virtual Player PlayerAtNC () { return NC; }
    public virtual Player PlayerAtNE () { return NE; }
    public virtual Player PlayerAtMW () { return MW; }
    public virtual Player PlayerAtMC () { return MC; }
    public virtual Player PlayerAtME () { return ME; }
    public virtual Player PlayerAtSW () { return SW; }
    public virtual Player PlayerAtSC () { return SC; }
    public virtual Player PlayerAtSE () { return SE; }

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
