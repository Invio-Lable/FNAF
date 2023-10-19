using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavScript : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agent;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.velocity.x !=0| agent.velocity.z !=0)
        {
            anim.SetBool("isMove", true);
        }
        else
        {
            anim.SetBool("isMove", false);  
        }
        
    }
}
