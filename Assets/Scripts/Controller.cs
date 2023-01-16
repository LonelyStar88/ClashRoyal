using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Controller : MonoBehaviour
{
    public static Controller Instance;

    [SerializeField] UIController uiCont;
    [SerializeField] CardController cardCont;
    // Start is called before the first frame update
    void Awake() => Instance = this;
    
}
