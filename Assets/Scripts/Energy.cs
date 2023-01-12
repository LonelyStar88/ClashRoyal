using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Energy : MonoBehaviour
{
    [SerializeField] private Image energyIMG;
    [SerializeField] private float maxEG;
    float curEG = 0;
    float time = 0f;
    // Start is called before the first frame update
    void Awake()
    {
        curEG = 0;
    }

    // Update is called once per frame
    void Update()
    {
        energyIMG.fillAmount = curEG / maxEG;
        time += Time.deltaTime;
        if(time > 1f)
        {
            time = 0f;
            if(curEG < maxEG)
            {
                curEG += 5;
            }
            
        }
    }
}
