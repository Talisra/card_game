using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castle : MonoBehaviour
{
    public GameObject CastleBody;
    public GameObject CastleBase;
    private float CastleBodyMaxHeight;
    public float MaxHP;
    private float CurrentHP;
    public BaseCard[] PassiveTriggerSpots { get; set; }
    public Player ControllingPlayer { get; set; }

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
        CurrentHP += amount;
        if (CurrentHP > MaxHP) // == Castle Win?
        {
            CurrentHP = MaxHP;
        }
        ScaleWithHP();
    }

    public void DestroyCastle(int amount)
    {
        Debug.Log("Function 'DestroyCastle(int amount)' Not Implemented!");
    }

    private void Initiate()
    {
        CastleBodyMaxHeight = CastleBody.transform.localScale.y;
        CurrentHP = MaxHP;
        ScaleWithHP();
    }

    private void Start()
    {
        Initiate();

        //DeveloperFunction();
    }

    private void DeveloperFunction()
    {
        CastleBodyMaxHeight = CastleBody.transform.localScale.y;
        MaxHP = 100;
        CurrentHP = Random.Range(0, 100);
        Debug.Log(CurrentHP / MaxHP);
        ScaleWithHP();
    }
}
