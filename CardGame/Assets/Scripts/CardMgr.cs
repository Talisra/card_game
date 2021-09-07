using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMgr : MonoBehaviour
{

    #region Properties
    public List<BaseCard> allGameCards;
    public List<BaseCard> playerPreferedCards;
    public Deck mainDeck;
    public int deckSize;
    #endregion


    #region Public Functions
    public void CreateDeck()
    {
        for (int i = 0; i < deckSize; i++)
        {
            var allGameCardIndex = Random.Range(0, allGameCards.Count);
            Debug.Log($"allGameCardIndex = {allGameCardIndex}");
            Debug.Log($"allGameCards.count = {allGameCards.Count}");
            var cardToAdd = allGameCards[allGameCardIndex];
            Debug.Log($"allGameCards.count = {allGameCards.Count}");
            Debug.Log($"cardToAdd = {cardToAdd}");
            mainDeck.AddCardToDeck(cardToAdd);
        }
    }

    public void LoadCards()
    {
        var loadedCards = Resources.LoadAll<BaseCard>("Cards");
        allGameCards.AddRange(loadedCards);
    }
    #endregion

    #region UnityFunctions
    void Start()
    {
        Init();
        LoadCards();
        CreateDeck();
    }

    #endregion

    #region Private Functions
    private void Init()
    {
        allGameCards = new List<BaseCard>();
        playerPreferedCards = new List<BaseCard>();
    }
    #endregion
}
