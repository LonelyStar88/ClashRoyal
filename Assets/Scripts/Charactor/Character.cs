using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public struct CharacterData
{
    public string findTag;
    public float atkRange;
}

public abstract class Character : MonoBehaviour
{
    public CharacterData charData = new CharacterData();
    public NavMeshAgent agent;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] characters = GameObject.FindGameObjectsWithTag("enemy");
        if (characters.Length == 0)
            return;

        float distance = 100f;
        GameObject findTarget = null;

        foreach(var character in characters)
        {
            //가장 가까운 적을 찾으면 적과 자신의 거리를 구하고 타겟을 그 적으로 잡는다.
            float dis = Vector3.Distance(agent.transform.position, character.transform.position);
            if (distance > dis)
            {
                findTarget = character;
                distance = dis;
            }
        }

        // 적이 없을경우 return
        if (findTarget == null)
            return;

        // AI가 목적지를 타겟의 위치로 잡는다.
        if (charData.atkRange < distance)
        {
            agent.SetDestination(findTarget.transform.position);
            ChangeAnim("Move");
        }
        else
        {
            ChangeAnim("Idle");
            agent.SetDestination(transform.position);
            // 캐릭터가 제자리에 정지해야하므로, AI의 목적지를 자기자신으로 한다.
            ChangeAnim("Attack");
        }
    }

    public virtual void ChangeAnim(string state)
    {
        animator.SetTrigger(state);
    }
}
