using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public abstract class Castle : MonoBehaviour
{
    [SerializeField] private float maxHP;
    [SerializeField] private Image imageHP;
    //[SerializeField] private TMP_Text textHP;
    //[SerializeField] private Image imageHPBG;
    public float curHP;
    
    

    private void Awake()
    {
        curHP = maxHP;
    }
    // Start is called before the first frame update
    void Start()
    {
        //imageHPBG.gameObject.SetActive(false);
        imageHP.fillAmount = curHP / maxHP;
        //CurHP = maxHP;
        //textHP.text = $"{(float)curHP}/{(float)maxHP}";
    }

    // Update is called once per frame
    void Update()
    {
        imageHP.fillAmount = curHP / maxHP;
        //textHP.text = $"{(float)curHP}/{(float)maxHP}";
        if (Input.GetKeyDown(KeyCode.F1))
        {
            //imageHPBG.gameObject.SetActive(true);
            if (curHP > 10)
            {
                curHP -= 10;
            }
            else if(curHP > 0 && curHP <= 10)
            {
                curHP = 0;
            }
            

        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            //imageHPBG.gameObject.SetActive(true);
            if (curHP < 90)
            {
                curHP += 10;
            }
            else if(curHP >= (maxHP - 10) && curHP < maxHP)
            {
                curHP = maxHP;
            }
            
        }
    }
}
