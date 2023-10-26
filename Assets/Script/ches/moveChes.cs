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
    public Transform player;
    private float rN;
    private void Start()
    {
        rN = Random.Range(10, 30);
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        Invoke("Move", rN);
    }

    void Move()
    {
        NextPoints points = checkpoint.GetComponent<NextPoints>();
        if (points is lastPoint)
        {
            lastPoint nearPoint = checkpoint.GetComponent<lastPoint>();
            bool isOpen = nearPoint.isOpen;
            if (isOpen)
            {
                agent.destination = player.position;
                agent.speed = 6;
            }
            else
            {
                checkpoint = points.getNext();
                agent.destination = checkpoint.position;
                Invoke("Move", 5f);
            }
        }
        else
        {
            checkpoint = points.getNext();
            agent.destination = checkpoint.position;
            Invoke("Move", rN);
        }
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

