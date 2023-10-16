using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class move : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform checkpoint;
    public Animator anim;
    public static int toPlayerChance;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = agent.GetComponent<Animator>();
        Invoke("Move", 10f);    
    }
    void Move()
    {
        NextPoints point= checkpoint.GetComponent<NextPoints>();
        checkpoint = point.getNext();
        agent.destination = checkpoint.position;
        Invoke("Move", 5f);
    }
    public void Update()
    {
        if (agent.velocity.x != 0 | agent.velocity.z != 0)
        {
            anim.SetBool("isMove", true);
        }
        else
        {
            anim.SetBool("isMove", false);
        }
    }
}
