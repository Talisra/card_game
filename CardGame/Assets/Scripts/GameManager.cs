using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Castle")]
    public float CastleMaxHP;
    public float CastleStartHP;

    [Header("Deck")]
    public int InitialCardsPerPlayer;

    public List<Player> AllPlayers;
    public List<PlayerSpace> PlayerSpaces;

    private CardMgr cardMgr;
    // Start is called before the first frame update

    private void Awake()
    {
        cardMgr = FindObjectOfType<CardMgr>();
    }
    void Start()
    {
        for (int i = 0; i < PlayerSpaces.Count; i++)
        {
            AllPlayers[i].SetPlayerSpace(PlayerSpaces[i]);
            AllPlayers[i].myCastle.Initiate(CastleMaxHP, CastleStartHP);
        }

        // give -InitialCardsPerPlayer- cards to the player via turn manager
    }

    public void StartGame()
    {
        cardMgr.CreateDeck();
        //turn manager start turn
    }

    public void CheckWinner()
    {
        foreach (Player player in AllPlayers)
        {
            if (player.myCastle.CurrentHP >= CastleMaxHP)
            {
                EndGame(player);
            }
        }
    }

    public void EndGame(Player winner)
    {
        //declare winner
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartGame();
        }
    }
}
