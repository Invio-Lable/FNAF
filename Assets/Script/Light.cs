using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    public GameObject doorLight;
    private Vector3 originalPosition;
    private float buttonPressDepth = -0.03f;
    public Battery energy;
    public AudioClip ButtonClip;
    public AudioClip LightClip;
    private AudioSource audioSource;

    private void Start()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    void Awake()
    {
        originalPosition = transform.localPosition;
    }
    private void Update() 
    {
        if(energy.energy <= 0) 
        {
            doorLight.SetActive(false);
        }
    }

    void OnMouseDown()
    {
        audioSource.PlayOneShot(ButtonClip);
        audioSource.PlayOneShot(LightClip);

        if (doorLight != null)
        {
            transform.localPosition = originalPosition - transform.up * buttonPressDepth;
            doorLight.SetActive(true);
        }
    }

    void OnMouseUp()
    {
        if (doorLight != null)
        {
            transform.localPosition = originalPosition;
            doorLight.SetActive(false);
        }
    }
}
