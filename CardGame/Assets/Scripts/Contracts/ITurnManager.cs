using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Contracts
{
    public interface ITurnManager
    {
        #region Props

        float TimeLeft { get; set; }
        float TurnTime { get; set; }
        Queue<IPlayer> Players { get; set; }
        #endregion

        #region Functions

        void SwitchTurns();

        #endregion
    }
}

