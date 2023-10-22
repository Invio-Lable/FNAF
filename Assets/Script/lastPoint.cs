using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastPoint : NextPoints
{
    public Door door;
    public bool isOpen;
    void Update()
    {
        isOpen = door.isOpen;
    }
}
