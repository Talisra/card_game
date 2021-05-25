using System.Collections.Generic;

namespace Assets.Scripts.Contracts
{
    public interface IDeck
    {
        #region Props
        List<ICard> MainDeck { get; set; }
        List<ICard> GraveyardDeck { get; set; }
        #endregion

        #region Functions
        ICard Draw();
        void Shuffle();
        ICard Peek();
        #endregion
    }
}
