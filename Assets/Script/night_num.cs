using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class night_num : MonoBehaviour
{
   // public clock clock;
    public int nightNum;
    public GameObject textObject;
    private Text num;

    private void Start()
    {
        nightNum = 0;
        nightNum++;
        num = textObject.GetComponent<Text>();
        num.text = "Night " + nightNum;  
    }
}
