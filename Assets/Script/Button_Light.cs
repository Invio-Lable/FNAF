using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public Light controlledLight; // Посилання на об'єкт світла

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0)) // Перевірка на натискання лівої кнопки миші
        {
            ToggleLight();
        }
    }

    private void ToggleLight()
    {
        if (controlledLight != null)
        {
            controlledLight.enabled = !controlledLight.enabled; // Вмикаємо/вимикаємо світло
        }
    }
}

