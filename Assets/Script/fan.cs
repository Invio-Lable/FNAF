using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fan : MonoBehaviour
{
    public float fanspeed = 1000;
    public AudioClip FanSound;
    private AudioSource audioSource;

    private void Start() {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    
        if (audioSource != null && audioSource.clip != null)
        {
            audioSource.Play();
        }
    }
    void Update()
    {   
        
        transform.Rotate(0, 0, fanspeed * Time.deltaTime);    
    }
}
