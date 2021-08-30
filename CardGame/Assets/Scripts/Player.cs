using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region Properties

    public Castle myCastle;
    public List<BaseCard> playerHand;
    public int availableResources;

    #endregion

    #region Public Functions
    public void UseCard()
    {
        Debug.Log("UseCardFromHand is not implemented yet!");
    }

    public void AddCardToHand(BaseCard cardToAdd)
    {
        Debug.Log("AddCardToHand is not implemented yet!");
    }
    #endregion

    #region Unity Functions
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    #endregion
}
