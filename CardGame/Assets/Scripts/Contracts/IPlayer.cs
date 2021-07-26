using System.Collections.Generic;

namespace Assets.Scripts.Contracts
{
    public interface IPlayer
    {
        #region Props
        ICastle Castle { get; set; }
        List<ICard> Hand { get; set; }
        int Resources { get; set; }
        #endregion

        #region Functions

        #endregion
    }
}


