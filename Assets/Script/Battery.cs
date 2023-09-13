using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubtractEveryTenSeconds : MonoBehaviour
{
    public Text textComponent; // Посилання на текстовий об'єкт UI

    private float timer = 0f;
    private int currentValue = 100;

    private void Start()
    {
        // Ініціалізуємо значення UI об'єкта
        textComponent.text = currentValue.ToString() + "%";

        // Запускаємо таймер
        timer = 1f;
    }

    private void Update()
    {
        // Відлічуємо час
        timer -= Time.deltaTime;

        // Якщо таймер сплив, віднімаємо 1 від значення і оновлюємо текст
        if (timer <= 0f)
        {
            currentValue -= 1;
            textComponent.text = currentValue.ToString() + "%";

            // Перезапускаємо таймер
            timer = 2f;
        }
    }
}
