using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.EventSystems.EventTrigger;

public class moveChes : MonoBehaviour
{
    public Battery energy;
    private NavMeshAgent agent;
    public Transform checkpoint;
    public Animator anim;
    public static int toPlayerChance;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        InvokeRepeating("Move", 0f, 10f);
    }

    void Move()
    {
        NextPoints point = checkpoint.GetComponent<NextPoints>();
        checkpoint = point.getNext();
        agent.destination = checkpoint.position;
    }

    public void Update()
    {
        
        if (agent.velocity.x != 0 || agent.velocity.z != 0)
        {
            anim.SetBool("isMove", true);
        }
        else
        {
            anim.SetBool("isMove", false);
        }
    }
}

