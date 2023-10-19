using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class night_num : MonoBehaviour
{
   // public clock clock;
    public int nightNum = 1;
    private Text num;
    private void Update()
    {
       //clock clock = gameObject.GetComponent<clock>();
       //if (clock.time == 6){
       //     nightNum++;
       // }
    }
    private void Awake()
    {
        num = gameObject.GetComponent<Text>();
        Timer();
    }

    private void Timer()
    {
        num.text = nightNum.ToString();
    }

}
