using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region Properties
    [HideInInspector]
    public Camera playerCamera; // The camera of the player
    public Transform cameraPoint; // The actual camera transform of the player in the arena
    public GameObject handAnchor; // The position anchor of the hand
    public Castle myCastle;
    //public List<BaseCard> playerHand;
    private ObservableCollection<BaseCard> playerHand = new ObservableCollection<BaseCard>();

    public int availableResources;

    public BaseCard temp;

    private float spaceBetweenCardsInHand = 0;
    private float cardWidth = 2.5f;
    #endregion

    #region Public Functions
    public void UseCard()
    {
        Debug.Log("UseCardFromHand is not implemented yet!");
    }

    public void AddCardToHand(BaseCard cardToAdd)
    {
        playerHand.Add(cardToAdd);
        cardToAdd.transform.SetParent(handAnchor.transform);
        cardToAdd.transform.localPosition = Vector3.zero;
        cardToAdd.transform.localRotation = Quaternion.identity;
        ArrangeCardsGraphic();
    }
    #endregion

    // This function works everytime the hand collection is changed
    private void OnHandChange(object sender, NotifyCollectionChangedEventArgs e)
    {
        ArrangeCardsGraphic();
    }

    private void ArrangeCardsGraphic()
    {
        float CardX = (playerHand.Count % 2 == 0) ? // Getting the x of the first card in hand depends on odd/even
            0 - cardWidth/2 - spaceBetweenCardsInHand/2 -
            (cardWidth + spaceBetweenCardsInHand) * ((playerHand.Count-1)/2) :
            0 - (cardWidth + spaceBetweenCardsInHand) * (playerHand.Count/2);
        foreach(BaseCard card in playerHand) // arrange the cards 
        {
            card.transform.localPosition = new Vector3(CardX, handAnchor.transform.position.y, handAnchor.transform.position.z);
            CardX += cardWidth + spaceBetweenCardsInHand;
        }
    }

    #region Unity Functions
    // Start is called before the first frame update
    void Awake()
    {
        playerCamera = Camera.main;
        playerCamera.transform.position = cameraPoint.position;
        Camera.main.transform.LookAt(Vector3.zero); // look at the center of the arena
    }

    private void Start()
    {
        playerHand.CollectionChanged += OnHandChange;
        // each card that is added to the player's hand must be reseted by
        // reset its local position and rotation and adding it to the handAnchor
        foreach (BaseCard card in playerHand)
        {
            card.transform.SetParent(handAnchor.transform);
            card.transform.localPosition = Vector3.zero;
            card.transform.localRotation = Quaternion.identity;
        }
        ArrangeCardsGraphic();
    }

    // Update is called once per frame
    void Update()
    {
    }
    #endregion
}
