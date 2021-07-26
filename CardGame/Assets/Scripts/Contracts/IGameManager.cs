using System.Collections;
using System.Collections.Generic;

namespace Assets.Scripts.Contracts
{
    public interface IGameManager
    {
        #region Props
        List<ICastle> Castles { get; set; }
        List<IPlayer> Players { get; set; }
        IDeck MainDeck { get; set; }
        ITurnManager TurnMgr { get; set; }
        #endregion

        #region Functions
        void Init();
        void EndGame();
        #endregion
    }
}

