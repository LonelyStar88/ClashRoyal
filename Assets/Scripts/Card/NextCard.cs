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
    // Start is called before the first frame update
    void Awake()
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
        for(int i = 0; i < images.Length; i++)
        {
            // 1�ʸ��� images �迭�� Card �������� �ӽ�ĭ�� �����ϰ� images �迭�� �ֱ�
            //images[i] = cards.Dequeue()
        }
    }

    public void NextCardAdd()
    {
        if (cards.Count == 4)
            return;

        Instantiate(card, parent);
    }

    //public CardData 
}
