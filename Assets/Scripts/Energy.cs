using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public struct energyBlock
{
    public Image energyIMG;
    public float curEG;
    public float maxEG;
    public bool isFull;
}
public class Energy : MonoBehaviour
{
    [SerializeField] private Image[] energyIMGs;
    energyBlock[] energys = new energyBlock[9];
    //float curEG = 0;
    float time = 0f;
    int index = 0;
    // Start is called before the first frame update
    void Awake()
    {
        //curEG = 0;
        emptygage();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        time += Time.deltaTime;
        if(time > 1f)
        {
            time = 0f;
            if (index < energys.Length)
            {
                StartCoroutine(fillgage(index));
            }
            else
            {
                StopCoroutine(fillgage(index));
            }
            if (energys[index].isFull)
            {
                index++;
            }
        }
    }
    void emptygage()
    {
        for(int i = 0; i < energyIMGs.Length; i++)
        {
            energys[i].energyIMG = energyIMGs[i];
            energys[i].energyIMG.fillAmount = 0;
            energys[index].curEG = 0;
            energys[i].maxEG = 50;
            energys[i].isFull = false;
        }
    }
    IEnumerator fillgage(int index)
    {
        if (!energys[index].isFull)
        {
            if (energys[index].curEG < energys[index].maxEG)
            {
                yield return new WaitForSeconds(0.1f);
                energys[index].curEG += 5;
                energyIMGs[index].fillAmount = energys[index].curEG / energys[index].maxEG;
                //index++;
            }
            else
            {
                yield return null;
                energys[index].curEG = energys[index].maxEG;
                energyIMGs[index].fillAmount = 1;
                energys[index].isFull = true;
            }
        }

    }
}
