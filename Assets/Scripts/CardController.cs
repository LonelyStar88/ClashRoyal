using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    [SerializeField] CardUI card;
    public int Index { get; set;}
    public bool Empty { get; set; }

    CardData cardData;

    public CardUI SellectCard()
    {
        return card;
    }
    public CardUI HideCard()
    {
        return card;
    }
    public int CardofIndex()
    {
        return 0;
    }
}
