using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public GameObject[] lights; // Масив лампочок, які можна включати/вимикати.
    private bool[] isLightOn; // Масив, щоб зберігати стан кожної лампочки.

    private void Start()
    {
        // Ініціалізуємо масив станів лампочок.
        isLightOn = new bool[lights.Length];

        // Вимикаємо всі лампочки при запуску гри.
        for (int i = 0; i < lights.Length; i++)
        {
            isLightOn[i] = false;
            lights[i].SetActive(false);
        }
    }

    private void OnMouseDown()
    {
        // Змінюємо стан кожної лампочки при кожному кліку.
        for (int i = 0; i < lights.Length; i++)
        {
            isLightOn[i] = !isLightOn[i];
            lights[i].SetActive(isLightOn[i]);
        }
    }
}
