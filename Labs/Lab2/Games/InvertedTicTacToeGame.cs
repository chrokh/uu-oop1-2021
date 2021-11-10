namespace Lab2
{
  class InvertedTicTacToeGame : TicTacToeGame
  {
    public override void PlayNW () { base.PlaySE(); }
    public override void PlayNC () { base.PlaySC(); }
    public override void PlayNE () { base.PlaySW(); }
    public override void PlayMW () { base.PlayME(); }
    public override void PlayMC () { base.PlayMC(); }
    public override void PlayME () { base.PlayMW(); }
    public override void PlaySW () { base.PlayNE(); }
    public override void PlaySC () { base.PlayNC(); }
    public override void PlaySE () { base.PlayNW(); }

    public override bool CanPlayNW () { return base.CanPlaySE(); }
    public override bool CanPlayNC () { return base.CanPlaySC(); }
    public override bool CanPlayNE () { return base.CanPlaySW(); }
    public override bool CanPlayMW () { return base.CanPlayME(); }
    public override bool CanPlayMC () { return base.CanPlayMC(); }
    public override bool CanPlayME () { return base.CanPlayMW(); }
    public override bool CanPlaySW () { return base.CanPlayNE(); }
    public override bool CanPlaySC () { return base.CanPlayNC(); }
    public override bool CanPlaySE () { return base.CanPlayNW(); }
  }
}
