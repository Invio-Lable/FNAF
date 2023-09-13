using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    private int time = 0;
    private Text clock;

    private void Awake() {
        clock = gameObject.GetComponent<Text>();
        InvokeRepeating("Timer", 90f, 90f);  // записано в секундах  
    }

    private void Timer() {
        time++;

        clock.text = time.ToString() + " AM";

        if (time >= 6) {
            CancelInvoke();     // Тут по факту має бути просто вигід з рівня та сцена перемоги і т.д
            Application.Quit();
        }
    }
}
