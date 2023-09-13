using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public Vector3 moveDistance = new Vector3(0.0f, 0.0f, 0.0f);

    private Vector3 originalPosition;
    private bool isDragging = false;

    private void Start()
    {
        originalPosition = transform.position;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.transform == transform)
            {
                isDragging = true;
            }
        }

        if (isDragging)
        {
            Vector3 newPosition = originalPosition + moveDistance;

            transform.position = newPosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (isDragging)
            {
                transform.position = originalPosition;
            }
            isDragging = false;
        }
    }
}