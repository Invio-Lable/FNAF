using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public GameObject screamer;
    public float sens = 500f;
    float rotateZone = Screen.width / 5;
    void Update()
    {
        if (screamer.activeSelf == false) {
            if (Input.mousePosition.x < rotateZone && transform.rotation.eulerAngles.y > 82)
            {
                transform.Rotate(0, -sens * Time.deltaTime, 0);
            }
            if (Input.mousePosition.x > Screen.width - rotateZone && transform.rotation.eulerAngles.y < 100)
            {
                transform.Rotate(0, sens * Time.deltaTime, 0);
            }
        } 
    }
}