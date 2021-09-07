using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealEffect : CardEffect
{
    public override void ActivateEffect(Player activatingPlayer, TargetType targetType, int value)
    {
        switch (targetType)
        {
            case TargetType.Self:
                {
                    activatingPlayer.myCastle.BuildCastle(value);
                    break;
                }
        }
    }
}
