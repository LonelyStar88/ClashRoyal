using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    [SerializeField] CardUI[] cardUI;
    
    [SerializeField] Transform[] parents;

    public int Index { get; set;}
    public bool Empty { get; set; }

    

    CardData cardData;

    // OnClick으로 해당 카드를 사용 및 삭제
    public CardUI SellectCard(int index)
    {
        CardUI returnCard = cardUI[index];
        cardUI[index] = null;
        return returnCard;
    }

    // Cost가 부족할 시, 이에 해당하는 카드들은 전부 사용 불가
    public void UseableCard(int cost)
    {
        foreach(var card in cardUI)
        {
            if(card.carddata.Cost > cost)
            {
                card.Useable = false;
            }
            else
            {
                card.Useable = true;
            }
        }
    }
  
}
