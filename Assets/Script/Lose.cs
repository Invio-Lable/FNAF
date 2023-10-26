using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Lose : MonoBehaviour
{
    public AudioClip sound_of_deied;
    private AudioSource audioSource;

    private void Start() {
        if (audioSource == null)
    {
      audioSource = GetComponent<AudioSource>();
    }
    audioSource.PlayOneShot(sound_of_deied);
    }

    public void night()
    {
        SceneManager.LoadSceneAsync("night");
    }
    public void Exit()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }
}
