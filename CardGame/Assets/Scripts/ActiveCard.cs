public class ActiveCard : BaseCard
{

    #region Properties
    public CardEffect cardEffect;
    #endregion

    #region Public Functions

    public override void ActivateSelf(Player activatingPlayer)
    {
        cardEffect.ActivateEffect(activatingPlayer, targetType, effectValue);
    }

    #endregion

    #region Unity Functions

    // Update is called once per frame
    void Update()
    {

    }
    #endregion
}
