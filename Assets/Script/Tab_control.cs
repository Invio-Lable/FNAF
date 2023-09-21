using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tab_control : MonoBehaviour
{
    public GameObject minimap;
    public GameObject[] cameras;
    public GameObject mainCamera;
    private int currentCameraIndex = 0;
    public Battery energy;
    public AudioClip TabClip;
    public AudioClip CameraClip;
    private AudioSource LaptopSound;

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
        
        LaptopSound.PlayOneShot(TabClip);
        
        minimap.SetActive(true);
        mainCamera.SetActive(false);
        cameras[currentCameraIndex].SetActive(true);
    }

    void Close()
    {
        
        LaptopSound.PlayOneShot(TabClip);
        
        cameras[currentCameraIndex].SetActive(false);
        mainCamera.SetActive(true);
        minimap.SetActive(false);
    }

    public void ChangeCamera(int index)
    {
        
        LaptopSound.PlayOneShot(CameraClip);
        
        cameras[currentCameraIndex].SetActive(false);
        currentCameraIndex= index;
        cameras[currentCameraIndex].SetActive(true);
    }
  
}
