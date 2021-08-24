using UnityEngine;
using UnityEngine.UI;

public enum CardType { Active = 'A', Passive = 'P', Trigger = 'T' };
public struct CostStruct
{
    int gold;
    int hp;
}

public enum CardState { Graveyard = 'G', FacedDown = 'F', InHand = 'H', InDeck = 'D' };
public enum TargetType { Self = 'S', Select = 'C', Others = 'O', All = 'A'};

public abstract class BaseCard : MonoBehaviour
{
    #region Properties
    public CardType cardType;
    public CostStruct cost;
    public bool isFacedUp;
    public CardState cardState;
    public string description;
    public Image cardImage;
    public TargetType target;
    #endregion

    #region Public Functions
    // Note 1- should the base card receive this or should it be there by default?
    // Note 2- should target type be a property of all card or just active and trigger?
    // Note 3- cardState and isFaceUp are somehow the same
    public abstract BaseCard ActivateSelf(Player player, TargetType targetType);

    public BaseCard Discard()
    {
        Debug.Log("Discard is not implemented yet so it returns null");
        return null;
    }

    public BaseCard Peek()
    {
        Debug.Log("Peek is not implemented yet so it returns null");
        return null;
    }

    public BaseCard PutUpsideDown()
    {
        Debug.Log("PutUpsideDown is not implemented yet so it returns null");
        return null;
    }
    #endregion

    #region Unity Functions
    public void Start()
    {
        
    }

    private void Update()
    {
        
    }
    #endregion

}
