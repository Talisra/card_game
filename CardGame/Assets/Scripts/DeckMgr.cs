using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckMgr : MonoBehaviour
{

    #region Properties
    public List<BaseCard> allGameCard;
    public List<BaseCard> playerPreferedCards;
    public Deck mainDeck;
    public int deckSize;
    #endregion


    #region Public Functions
    public void CreateDeck()
    {
        Debug.Log("CreateDeck is not yet implemented");
    }

    public void LoadCards()
    {
        Debug.Log("LoadCards is not yet implemented");
    }
    #endregion

    #region UnityFunctions
    void Start()
    {
        LoadCards();
        CreateDeck();
    }

    void Update()
    {

    }
    #endregion
}
