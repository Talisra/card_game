using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public abstract class CardEffect : MonoBehaviour
{
    #region Properties
    [SerializeField] protected List<ParticleSystem> effects;
    #endregion

    #region Public Functions

    public abstract void ActivateEffect(Player activatingPlayer, TargetType targetType, int value);

    #endregion

    #region Private Functions
    // shows a particle at a transform target.
    protected void ShowParticle(ParticleSystem particle, Transform location)
    {
        particle.transform.position = location.position;
        particle.Play();
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
