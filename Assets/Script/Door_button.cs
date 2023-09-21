using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_button : MonoBehaviour
{
    Vector3 position;
    public Door door;
    public AudioClip ButtonClip;
    private AudioSource audioSource;

    private void Start()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }
    
    private void OnMouseDown() {
        if (audioSource != null && audioSource.clip != null)
            {
                audioSource.Play();
            }
        door.ButtonPressed();
        Invoke("MouseUp", 0.1f);
    } 
}
