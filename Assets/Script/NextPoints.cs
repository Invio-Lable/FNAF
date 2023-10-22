using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPoints : MonoBehaviour
{   
    int chance;
    public int id;
    public Transform[] NextCheckPoints;
    public int toPlayerChance;
    public void Awake()
    {
        StartChance();
    }
    void StartChance()
    {
        
        move.toPlayerChance = 75;
        chance = move.toPlayerChance;
        moveChes.toPlayerChance = 100;
        chance = moveChes.toPlayerChance;
    }

    public Transform getNext()
    {
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
