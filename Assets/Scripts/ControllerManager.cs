using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControllerManager : MonoBehaviour
{
    public static ControllerManager Instance;

    [SerializeField] UIController uiCont;
    [SerializeField] CardController cardCont;
    [SerializeField] DataController dataCont;
    public NextCard nextCard;

    int cost = 0;
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
        nextCard.Initialize();
        InvokeRepeating("AddCost", 1f, 1f);

    }

    void Update()
    {
        cardCont.UseableCard(cost);
    }

    void AddCost()
    {
        if (cost < 9)
        {
            cost++;
        }
    }
}
