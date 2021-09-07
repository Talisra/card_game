using UnityEngine;
using UnityEngine.UI;

public enum CardType { Active = 'A', Passive = 'P', Trigger = 'T' };
public struct CostStruct
{
    int gold;
    int hp;
}
public enum TargetType { Self = 'S', Select = 'C', Others = 'O', All = 'A'};

public abstract class BaseCard : MonoBehaviour
{
    #region Properties
    public string cardName;
    public Sprite cardSprite;
    public string cardDescription;
    public CardType cardType;
    public CostStruct cost;
    public TargetType targetType;
    public int effectValue;

    // Card visuals
    public Image cardImageUI;
    public Text cardNameUI;
    public Text cardDescriptionUI;
    #endregion

    #region Public Functions
    public abstract void ActivateSelf(Player activatingPlayer);

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
        cardImageUI.sprite = cardSprite;
        cardDescriptionUI.text = cardDescription;
        cardNameUI.text = cardName;
    }

    private void Update()
    {

    }
    #endregion

}
