using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Goblin : Character
{
    private NavMeshAgent Gagent;
    // Start is called before the first frame update
    void Start()
    {
        charData.findTag = "enemy";
        charData.atkRange = 1f;
        Gagent = agent;
    }

    // Update is called once per frame
    void Update()
    {
        FindTarget(Gagent);
    }

    public override void FindTarget(NavMeshAgent agent)
    {
        base.FindTarget(agent);
    }
    public override void ChangeAnim(string state)
    {
        base.ChangeAnim(state);
    }
}
