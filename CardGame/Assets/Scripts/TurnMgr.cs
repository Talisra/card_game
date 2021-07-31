using Assets.Scripts.Contracts;
using System.Collections.Generic;
using UnityEngine;

public enum CounterType { Bar, Clock }
public class TurnMgr : MonoBehaviour
{
    #region Fields
    public float turnTime;
    public Queue<IPlayer> players;
    public CounterType counterType;
    public TimeUi timeUi;

    private float timeLeft;
    private int turnCounter;
    private int roundCounter;
    #endregion

    #region Public Core Functions
    public void SwitchTurns()
    {
        //players.Enqueue(players.Dequeue()); relvent when players will be created
        turnCounter++;
        roundCounter = (turnCounter % /*players.Count*/4) + 1;
    }

    public void EndTurn()
    {
        SwitchTurns();
        InitTimerValues();
    }
    #endregion

    #region Unity Functions
    void Start()
    {
        InitTimerValues();
        timeUi.ConfigureTimerVisuals(counterType, turnTime);
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        timeUi.UpdateVisuals(counterType, timeLeft);
        if (timeLeft <= 0)
        {
            EndTurn();
        }
    }
    #endregion

    #region Private Functions
    private void InitTimerValues()
    {
        timeLeft = turnTime;
    }
    #endregion

}
