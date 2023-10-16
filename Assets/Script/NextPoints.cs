using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPoints : MonoBehaviour
{   
    int chance;
    public int id;
    public Transform[] NextCheckPoints;

    public void Awake()
    {
        StartChance();
    }
    void StartChance()
    {
        move.toPlayerChance = 75;
        chance = move.toPlayerChance;
    }

    void SetChance()
    {
        if (id == 1)
        {
            move.toPlayerChance = 100;
        }
        else if (id==8 | id == 6 )
        {
            move.toPlayerChance = 0;
        }
    }

    public Transform getNext()
    {
        //SetChance();
        chance = move.toPlayerChance;
        int  rand = Random.Range(1, 100);
        if (rand <= chance)
        {
            if(NextCheckPoints.Length > 1)
            {
                return NextCheckPoints[Random.Range(1, NextCheckPoints.Length)];
            }
            else
            {
                return NextCheckPoints[0];
            }
        }
        else
        {
            return NextCheckPoints[0];
        }
    }
}
