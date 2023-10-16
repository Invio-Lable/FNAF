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
        InvokeRepeating("Timer", 10f, 10f);  // �������� � ��������  
    }

    private void Timer()
    {
        time++;

        Clock.text = time.ToString() + " AM";

        if (time >= 6)
        {
            CancelInvoke();     // ��� �� ����� �� ���� ������ ���� � ���� �� ����� �������� � �.�
            SceneManager.LoadScene("MainMenu");
        }
    }

}
