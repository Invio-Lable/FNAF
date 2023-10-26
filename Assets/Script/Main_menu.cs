using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_menu : MonoBehaviour
{
  public AudioClip sound_of_lobby;
  private AudioSource audioSource;

  void Start() 
  {
    if (audioSource == null)
    {
      audioSource = GetComponent<AudioSource>();
    }
    audioSource.PlayOneShot(sound_of_lobby);
  }
  public void PlayGame ()
    {
      SceneManager.LoadSceneAsync("night");
    }
  public void Exit()
    {
      Application.Quit();
    }
}
