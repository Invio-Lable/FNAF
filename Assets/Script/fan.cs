using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fan : MonoBehaviour
{
    public float fanspeed = 1000;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, fanspeed * Time.deltaTime);    
    }
}
