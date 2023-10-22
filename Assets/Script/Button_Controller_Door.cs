using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Transform door;             // Двері, які будемо опускати та піднімати
    public float moveDistance = 1.0f;  // Відстань опускання/піднімання
    private Vector3 originalPosition;  // Початкова позиція дверей
    private bool isMoving = false;     // Прапорець, що вказує, що двері в русі

    private void Start()
    {
        originalPosition = door.position;
    }

    private void Update()
    {
        // Перевірка на натискання кнопки (наприклад, клавіші "E")
        if (Input.GetKeyDown(KeyCode.E) && !isMoving)
        {
            isMoving = true;
            StartCoroutine(MoveDoor());
        }
    }

    private IEnumerator MoveDoor()
    {
        Vector3 targetPosition;

        if (door.position == originalPosition)
        {
            // Опустити двері
            targetPosition = originalPosition - new Vector3(0f, moveDistance, 0f);
        }
        else
        {
            // Підняти двері
            targetPosition = originalPosition;
        }

        float startTime = Time.time;
        float journeyLength = Vector3.Distance(door.position, targetPosition);
        float journeyTime = 0.5f; // Загальний час переміщення (в секундах)

        while (Time.time - startTime < journeyTime)
        {
            float distanceCovered = (Time.time - startTime) * journeyLength / journeyTime;
            float fractionOfJourney = distanceCovered / journeyLength;
            door.position = Vector3.Lerp(door.position, targetPosition, fractionOfJourney);
            yield return null;
        }

        door.position = targetPosition;
        isMoving = false;
    }
}
