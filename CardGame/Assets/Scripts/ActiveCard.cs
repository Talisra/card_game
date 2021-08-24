public class ActiveCard : BaseCard
{

    #region Properties
    public CardEffect cardEffect;
    #endregion

    #region Public Functions

    public override BaseCard ActivateSelf(Player player, TargetType targetType)
    {
        return cardEffect.ActivateSelf(player,targetType);
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
