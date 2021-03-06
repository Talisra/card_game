using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum CounterType { Bar, Clock }
public class TurnMgr : MonoBehaviour
{
    #region Fields
    public float turnTime;
    public List<Player> allPlayers;
    public Queue<Player> turnQueue;
    public Deck mainDeck;

    private float timeLeft;
    private int turnCounter;
    private int roundCounter;
    #endregion

    #region GuiRelated
    const string RoundCounterPrefix = "Round ";
    const string TurnCounterPrefix = "Turn ";
    public TimeUi timeUi;
    public Text roundCounterTxt;
    public Text turnCounterTxt;
    public CounterType counterType;
    #endregion

    #region Public Core Functions
    public void SwitchTurns()
    {
        turnQueue.Enqueue(turnQueue.Dequeue()); // relvent when players will be created
        var currentPlayer = turnQueue.Peek();
        mainDeck.Draw(currentPlayer);
    }

    public void EndTurn()
    {
        SwitchTurns();
        InitTimerValues();
    }
    #endregion

    #region Unity Functions

    private void Awake()
    {
        turnQueue = new Queue<Player>();
        foreach(Player player in allPlayers)
        {
            turnQueue.Enqueue(player);
        }
    }
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
        if (turnCounter % /*players.Count*/4 == 0)
        {
            roundCounter++;
        }
        turnCounter++;
        roundCounterTxt.text = RoundCounterPrefix + roundCounter;
        turnCounterTxt.text = TurnCounterPrefix + turnCounter;
    }
    #endregion

}
