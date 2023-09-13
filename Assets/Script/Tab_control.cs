using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tab_control : MonoBehaviour
{
    public GameObject minimap;
    public GameObject[] cameras;
    public GameObject mainCamera;
    private int currentCameraIndex = 0;

    public void tabChangeVisible()
    {
        if (minimap.activeSelf)
        {
            Close();
        }
        else
        {
            Open();
        }
    }
    
    void Open()
    {
        minimap.SetActive(true);
        mainCamera.SetActive(false);
        cameras[currentCameraIndex].SetActive(true);
    }

    void Close()
    {
        cameras[currentCameraIndex].SetActive(false);
        mainCamera.SetActive(true);
        minimap.SetActive(false);
    }

    public void ChangeCamera(int index)
    {
        cameras[currentCameraIndex].SetActive(false);
        currentCameraIndex= index;
        cameras[currentCameraIndex].SetActive(true);
    }
  
}
