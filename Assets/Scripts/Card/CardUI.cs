using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardUI : MonoBehaviour
{
    
    public GameObject card;
    //[SerializeField] Transform[] parents;
    [SerializeField] NextCard nextcard;

    public GameObject[] cards;

    public CardData carddata;
    public bool Useable { get; set; }
    int count = 0;
    public void Initialize()
    {
       carddata = nextcard.SelectCard(); // NextCard���� CardData�� ��ȯ
       card = nextcard.CardIMG();
       count++;
    }
}
