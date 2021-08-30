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
    public CardType cardType;
    public CostStruct cost;
    public string description;
    public Image cardImage;
    public TargetType targetType;
    #endregion

    #region Public Functions
    public abstract BaseCard ActivateSelf(Player activatingPlayer);

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
