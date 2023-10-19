using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tab_control : MonoBehaviour
{
    //public GameObject Tablet;
    //public Animator anim;
    public GameObject minimap;
    public GameObject Image;
    public GameObject[] cameras;
    public GameObject[] light;
    public GameObject mainCamera;
    private int currentCameraIndex = 0;
    public Battery energy;
    public AudioClip TabClip;
    public AudioClip CameraClip;
    private AudioSource LaptopSound;

    //private void Awake()
    //{
      //  anim=Tablet.GetComponent<Animator>();
   // }
    private void Start() {
        if (LaptopSound == null)
        {
            LaptopSound = GetComponent<AudioSource>();
        }
    }

    public void tabChangeVisible()
    {
        if (minimap.activeSelf || energy.energy <=0)
        {
            Close();
        }
        else
        {
            Open();
        }
    }
    
    private void Update(){
        if(energy.energy <=0){
            Close();
        }
    }

    void Open()
    {
       //   anim.SetBool("isOpen", true);
       // yield return new WaitForSeconds(0.4f);
        LaptopSound.PlayOneShot(TabClip);
        Image.SetActive(true);
        minimap.SetActive(true);
        mainCamera.SetActive(false);
        cameras[currentCameraIndex].SetActive(true);
        
    }

    public void Close()
    {
        Image.SetActive(false);
        LaptopSound.PlayOneShot(TabClip);
        light[currentCameraIndex].SetActive(false); 
        cameras[currentCameraIndex].SetActive(false);
        mainCamera.SetActive(true);
        minimap.SetActive(false);
       // anim.SetBool("isOpen", false);
    }

    public void ChangeCamera(int index)
    {
        
        LaptopSound.PlayOneShot(CameraClip);
        light[currentCameraIndex].SetActive(false);
        cameras[currentCameraIndex].SetActive(false);
        currentCameraIndex= index;
        cameras[currentCameraIndex].SetActive(true);
        light[currentCameraIndex].SetActive(true);
    }
  
}
