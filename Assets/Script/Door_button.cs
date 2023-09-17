using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_button : MonoBehaviour
{
    Vector3 position;
    public Door door;
    
    private void OnMouseDown(){
        door.ButtonPressed();
        Invoke("MouseUp", 0.1f);
    } 
}
