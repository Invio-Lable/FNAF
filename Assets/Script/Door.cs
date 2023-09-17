using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Vector3 openPosition;
    public Vector3 closePosition;
    public bool isOpen = true;
    public bool action = false;

    // Start is called before the first frame update
    public void ButtonPressed()
    {
        isOpen = !isOpen;
        action = true;
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 NextPosition;
        if(isOpen){
            NextPosition = openPosition;
        }else{
            NextPosition = closePosition;
        }if(action){
            transform.localPosition = Vector3.Lerp(transform.localPosition, NextPosition, 12f * Time.deltaTime);
            if(Vector3.Distance(transform.localPosition, NextPosition)< 0.01f){
                transform.localPosition = NextPosition;
                action = false;
            }
        }
    }
}