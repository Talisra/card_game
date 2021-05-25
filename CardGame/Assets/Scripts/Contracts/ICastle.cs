namespace Assets.Scripts.Contracts
{
    public interface ICastle
    {
        #region Props
        int Hp { get; set; }
        ICard[] PassiveTriggerSpots { get; set; }
        IPlayer Player { get; set; } // circular reference???
        #endregion

        #region Functions
        void BuildCastle(int amount);
        void DestroyCastle(int amount);
        #endregion
    }
}
