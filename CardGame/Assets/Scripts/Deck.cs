using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    #region Properties
    public List<BaseCard> currentGameCards;

    public float baseScale = 0.05f;
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

        float newDeckSize = baseScale * (currentGameCards.Count);
        Debug.LogWarning($"newDeckSize = {newDeckSize}");
        gameObject.transform.localScale = new Vector3( // Adjust Height Scale
            gameObject.transform.localScale.x,
            newDeckSize,
            gameObject.transform.localScale.z);

        gameObject.transform.position = new Vector3( // Adjust y position, based on the Base of the castle
            gameObject.transform.position.x,
            gameObject.transform.position.y + (baseScale),
            gameObject.transform.position.z
            );
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
