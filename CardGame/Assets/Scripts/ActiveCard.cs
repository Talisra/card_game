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
    private void OnMouseDown()
    {
        ActivateSelf(FindObjectOfType<Player>());
    }

    // Update is called once per frame
    void Update()
    {

    }
    #endregion
}
