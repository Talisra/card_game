namespace Assets.Scripts.Contracts
{
    public interface ICard
    {
        #region Props
        int Cost { get; set; }
        string Type { get; set; }
        #endregion

        #region Functions
        ICard Use();
        ICard Discard();
        ICard Peek();
        ICard PutUpsideDown();
        #endregion
    }
}

