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
            //���� ����� ���� ã���� ���� �ڽ��� �Ÿ��� ���ϰ� Ÿ���� �� ������ ��´�.
            float dis = Vector3.Distance(agent.transform.position, character.transform.position);
            if (distance > dis)
            {
                findTarget = character;
                distance = dis;
            }
        }

        // ���� ������� return
        if (findTarget == null)
            return;

        // AI�� �������� Ÿ���� ��ġ�� ��´�.
        if (charData.atkRange < distance)
        {
            agent.SetDestination(findTarget.transform.position);
            ChangeAnim("Move");
        }
        else
        {
            ChangeAnim("Idle");
            agent.SetDestination(transform.position);
            // ĳ���Ͱ� ���ڸ��� �����ؾ��ϹǷ�, AI�� �������� �ڱ��ڽ����� �Ѵ�.
            ChangeAnim("Attack");
        }
    }

    public virtual void ChangeAnim(string state)
    {
        animator.SetTrigger(state);
    }
}
