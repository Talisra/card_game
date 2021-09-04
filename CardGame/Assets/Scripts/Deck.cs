using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    #region Properties
    public List<BaseCard> currentGameCards;
    #endregion


    #region Public Functions
    public void Draw()
    {
        Debug.Log("Draw is not yet implemented");
    }

    public void AddCardToDeck(BaseCard cardToAdd)
    {
        if(cardToAdd == null)
        {
            Debug.Log("Card cannot be null");
            return;
        }
        currentGameCards.Add(cardToAdd);
    }
    #endregion

    #region UnityFunctions
    void Start()
    {
        currentGameCards = new List<BaseCard>();
    }

    void Update()
    {

    }
    #endregion
}
