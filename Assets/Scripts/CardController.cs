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

    // OnClick���� �ش� ī�带 ��� �� ����
    public CardUI SellectCard(int index)
    {
        CardUI returnCard = cardUI[index];
        cardUI[index] = null;
        return returnCard;
    }

    // Cost�� ������ ��, �̿� �ش��ϴ� ī����� ���� ��� �Ұ�
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
