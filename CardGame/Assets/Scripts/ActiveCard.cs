public class ActiveCard : BaseCard
{

    #region Properties
    public CardEffect cardEffect;
    #endregion

    #region Public Functions

    public override BaseCard ActivateSelf(Player activatingPlayer)
    {
        return cardEffect.ActivateEffect(activatingPlayer, targetType);
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
