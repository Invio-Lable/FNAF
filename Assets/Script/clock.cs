using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class clock : MonoBehaviour
{
    private int time = 0;
    private Text Clock;
    private void Awake()
    {

        Clock = gameObject.GetComponent<Text>();
        InvokeRepeating("Timer", 10f, 10f);  // записано в секундах  
    }

    private void Timer()
    {
        time++;

        Clock.text = time.ToString() + " AM";

        if (time >= 6)
        {
            CancelInvoke();     // Тут по факту має бути просто вигід з рівня та сцена перемоги і т.д
            SceneManager.LoadScene("MainMenu");
        }
    }

}
