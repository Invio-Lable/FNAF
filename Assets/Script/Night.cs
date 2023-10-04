using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Night : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("restouran");
    }
}
