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
        var allGeneratedCards = new List<BaseCard>();
        for (int i = 0; i < deckSize; i++)
        {
            var allGameCardIndex = Random.Range(0, allGameCards.Count);
            var cardToAdd = allGameCards[allGameCardIndex];
            BaseCard cardGameObject = PrefabPooler.Instance.Get(
                cardToAdd.name,
                new Vector3(-100, -100, -100),
                Quaternion.identity).GetComponent<BaseCard>();
            cardGameObject.gameObject.SetActive(false);

            allGeneratedCards.Add(cardGameObject);
        }
        mainDeck.AddCardsToDeck(allGeneratedCards);
    }

    public void LoadCards()
    {
        var loadedCards = Resources.LoadAll<BaseCard>("Cards");
        allGameCards.AddRange(loadedCards);
    }
    #endregion

    #region UnityFunctions

    private void Awake()
    {
        Init();
        LoadCards();
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
