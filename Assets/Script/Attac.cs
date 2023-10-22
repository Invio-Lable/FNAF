using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Attac : MonoBehaviour
{
    public GameObject screamer;     
    public GameObject UI;
    Tab_control cameras;
    Animator anim;
    public AudioClip sound_of_screamer;
    private AudioSource audioSource;

    private void Start() {
        
    }
    private void Awake()
    {
        anim = screamer.GetComponent<Animator>();
        cameras = UI.GetComponent<Tab_control>();
        audioSource = screamer.AddComponent<AudioSource>();
        audioSource.clip = sound_of_screamer;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Invoke("end", 1f);
            cameras.Close();
            Destroy(UI);
            gameObject.SetActive(false);
            screamer.SetActive(true);
            anim.SetBool("Scream", true);
            audioSource.Play();
        }
    }
    public void end()
    {
        SceneManager.LoadScene("Lose");
    }
}
