using UnityEngine;

public abstract class CardEffect : MonoBehaviour
{
    #region Properties
    public TargetType targetType;
    public string description;
    public int cardValue;
    #endregion

    #region Public Functions

    public abstract BaseCard ActivateSelf(Player player, TargetType targetType);

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
