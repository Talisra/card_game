using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    #region Properties
    public List<BaseCard> currentGameCards;

    public float baseScale = 0.05f;
    public float baseYHeigt;
    #endregion


    #region Public Functions
    public void Draw(Player currentPlayer)
    {
        Debug.Log($"currentGameCards before = {currentGameCards.Count}");
        BaseCard drawnCard = currentGameCards[currentGameCards.Count - 1];
        drawnCard.gameObject.SetActive(true);
        currentPlayer.AddCardToHand(drawnCard);
        currentGameCards.RemoveAt(currentGameCards.Count - 1);
        Debug.Log($"currentGameCards after = {currentGameCards.Count}");
        RenderDeckSize();
    }

    public void AddCardToDeck(BaseCard cardToAdd)
    {
        if (cardToAdd == null)
        {
            Debug.Log("Card cannot be null");
            return;
        }
        currentGameCards.Add(cardToAdd);
        RenderDeckSize();
    }

    public void AddCardsToDeck(List<BaseCard> cardsToAdd)
    {
        if (cardsToAdd == null)
        {
            Debug.Log("Cards cannot be null");
            return;
        }
        currentGameCards.AddRange(cardsToAdd);
        RenderDeckSize();
    }

    public void RenderDeckSize()
    {
        float newDeckSize = baseScale * (currentGameCards.Count);
        //Debug.LogWarning($"newDeckSize = {newDeckSize}");
        gameObject.transform.localScale = new Vector3( // Adjust Height Scale
            gameObject.transform.localScale.x,
            newDeckSize,
            gameObject.transform.localScale.z);

        gameObject.transform.position = new Vector3( // Adjust y position, based on the Base of the castle
            gameObject.transform.position.x,
            baseYHeigt + (newDeckSize / 2),
            gameObject.transform.position.z
            );
    }
    #endregion

    #region UnityFunctions
    void Awake()
    {
        currentGameCards = new List<BaseCard>();
        gameObject.transform.position = new Vector3(
            gameObject.transform.position.x,
            baseYHeigt,
            gameObject.transform.position.z);
    }

    void Update()
    {

    }
    #endregion
}
