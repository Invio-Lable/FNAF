/*using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Attac : MonoBehaviour
{
    public GameObject screamer;
    public GameObject tab;
    public GameObject UI;
    Tab_control cameras;
    Animator anim;

    private void Awake()
    {
        anim = screamer.GetComponent<Animator>();
        cameras = UI.GetComponent<Tab_control>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Invoke("end", 1f);
            cameras.Close();
            Destroy(tab);
            Destroy(UI);
            gameObject.SetActive(false);
            screamer.SetActive(true);
            anim.SetBool("Scream", true); 
        }
    }
    public void end()
    {
        SceneManager.LoadScene("Lose");
    }
}
*/