using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circlePl : MonoBehaviour
{
    private bool isDragging = false;
    private bool isSquare = false;
    private Vector2 originalPosition;
    private Transform draggedObject;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse key down");
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                isDragging = true;
                draggedObject = hit.transform;
                originalPosition = hit.transform.position;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Mouse key up");
            if (isDragging)
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                if (!isSquare)
                {
                    draggedObject.position = originalPosition;
                }
                isDragging = false;
            }
        }

        if (isDragging)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            draggedObject.position = new Vector2(mousePosition.x, mousePosition.y);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        isSquare = other.gameObject.CompareTag("blue");
    }

}

