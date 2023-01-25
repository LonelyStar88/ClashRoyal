using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class NextCard : MonoBehaviour
{
    [SerializeField] TMP_Text costText;
    [SerializeField] Transform parent;
    [SerializeField] GameObject card;
    public GameObject[] images = new GameObject[4];
    Queue<CardData> cards = new Queue<CardData>();

    //RectTransform trans = GetComponent<RectTransform>();
    int cost = 0;
    int count = 0;
    
    public void Initialize()
    {
        for(int i = 0; i < 10; i++)
        {
            NextCardAdd();
        }
        InvokeRepeating("NextCardAdd", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void NextCardAdd()
    {
        if (cards.Count == 4)
            return;

        if (count < images.Length - 1)
        {
            if (images[count] != null)
            {
                cards.Enqueue(CreateCard());
                images[count] = Instantiate(card, parent);
                count++;
            }
        }
        count = images.Length - 1;
    }

    public CardData CreateCard()
    {
        CardData tempcard = new CardData();
        tempcard.Cost = Random.Range(1, 5);
        tempcard.Speed = 1.5f;

        return tempcard;
    }
    public CardData SelectCard()
    {
        CardData tempcard = cards.Dequeue();
        return tempcard;
    }
    public GameObject CardIMG()
    {
        return card;
    }
   
}
