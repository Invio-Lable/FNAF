using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Vector3 openPosition;
    public Vector3 closePosition;
    public bool isOpen = true;
    public bool action = false;
    public Battery energy;
    public AudioClip DoorCloseClip;
    public AudioClip DoorOpenClip;
    private AudioSource audioSource;

    private void Start()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }
    public void ButtonPressed()
    {
        if(energy.energy > 0) 
        {
            isOpen = !isOpen;
            action = true;
        }
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 NextPosition;
        if(energy.energy <= 0)
        {
            isOpen = true;
            action = true;
        }

        if(isOpen)
        {
            NextPosition = openPosition;
        }
        else
        {
            NextPosition = closePosition;
        }

        if(action)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, NextPosition, 12f * Time.deltaTime);
            if(Vector3.Distance(transform.localPosition, NextPosition)< 0.01f)
            {
                transform.localPosition = NextPosition;
                action = false;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy") {
        action = true;
        isOpen = true;
        }
    }
}
