using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Night : MonoBehaviour
{
    private int night = 0;
    private Text num;
    IEnumerator Start()
    {
        yield return new WaitForSeconds(2f);
        //Timer();
        SceneManager.LoadScene("restouran");
    }
    private void Awake()
    {
        num = gameObject.GetComponent<Text>();

    }

    /*private void Timer()
    {
        night++;

        num.text = night.ToString()+"";
    }*/
}