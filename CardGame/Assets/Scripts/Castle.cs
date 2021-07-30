using Assets.Scripts.Contracts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castle : MonoBehaviour, Assets.Scripts.Contracts.ICastle
{
    public GameObject CastleBody;
    public GameObject CastleBase;
    private float CastleBodyMaxHeight;
    public float MaxHP { get; set; } 
    public float CurrentHP { get; set; } 
    public ICard[] PassiveTriggerSpots { get; set; }
    public IPlayer Player { get; set; }

    public void ScaleWithHP()
    {
        float newCastleHeight = CastleBodyMaxHeight * (CurrentHP / MaxHP);
        CastleBody.transform.localScale = new Vector3( // Adjust Height Scale
            CastleBody.transform.localScale.x,
            newCastleHeight,
            CastleBody.transform.localScale.z);
        CastleBody.transform.position = new Vector3( // Adjust y position, based on the Base of the castle
            CastleBody.transform.position.x,
            CastleBase.transform.position.y + (newCastleHeight / 2),
            CastleBody.transform.position.z
            );
    }

    public void BuildCastle(int amount)
    {
        throw new System.NotImplementedException();
    }

    public void DestroyCastle(int amount)
    {
        throw new System.NotImplementedException();
    }

    private void Start()
    {
        // Dev Code!
        CastleBodyMaxHeight = CastleBody.transform.localScale.y;
        MaxHP = 100;
        CurrentHP = Random.Range(0, 100);
        Debug.Log(CurrentHP/MaxHP);
        ScaleWithHP();
        // End of Dev Code
    }

}
