using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("night");
    }
    public void MainMenu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }

}
