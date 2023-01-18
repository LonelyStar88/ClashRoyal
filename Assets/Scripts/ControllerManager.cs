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
    // Start is called before the first frame update
    void Awake() => Instance = this;
    
}
