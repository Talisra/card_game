namespace Assets.Scripts.Contracts
{
    public interface IArena
    {
        #region Props
        ICastle[] Castles { get; set; }
        IPlayer[] Players { get; set; }
        IDeck MainDeck { get; set; }
        double TurnTimer { get; set; }
        #endregion

        #region Functions
        void DealCards();
        void TransferTurn();
        #endregion
    }
}
