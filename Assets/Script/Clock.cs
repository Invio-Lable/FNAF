using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class clock : MonoBehaviour
{
   // private night_num night_num;
    public int time = 0;
    private Text Clock;
    private void Awake()
    {
        //night_num night_num = gameObject.GetComponent<night_num>();
        Clock = gameObject.GetComponent<Text>();
        InvokeRepeating("Timer", 90f, 90f);  // �������� � ��������  
    }

    private void Timer()
    {
        time++;

        Clock.text = time.ToString() + " AM";

        if (time >= 6)
        {
            CancelInvoke();     // ��� �� ����� �� ���� ������ ���� � ���� �� ����� �������� � �.�
            SceneManager.LoadScene("Win");
        }
    }
    

}
