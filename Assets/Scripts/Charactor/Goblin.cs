using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Character
{
    
    // Start is called before the first frame update
    void Start()
    {
        charData.findTag = "enemy";
        charData.atkRange = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
