using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Lose : MonoBehaviour
{
    public void night()
    {
        SceneManager.LoadSceneAsync("night");
    }
    public void Exit()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }
}
