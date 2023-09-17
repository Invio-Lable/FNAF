using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_menu : MonoBehaviour
{
  public void PlayGame ()
    {
        SceneManager.LoadSceneAsync("restouran");
    }
  public void Exit()
    {
        Application.Quit();
    }
}
