using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class circleP : MonoBehaviour
{
    private bool isDragging = false;
    private bool isSquare = false;
    private Vector2 originalPosition;
    private Transform draggedObject;
    public Scenes sceneManager;


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
                } else
                {
                    sceneManager.decrement();
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

    private void isObjectTag(Collider2D other, string tag)
    {
        isSquare = other.gameObject.CompareTag(tag);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        switch(this.tag)
        {
            case "paper":
                isObjectTag(other, "paperbox");
                break;
            case "plastic":
                isObjectTag(other, "plasticbox");
                break;
            case "organic":
                isObjectTag(other, "organicbox");
                break;
            case "glass":
                isObjectTag(other, "glassbox");
                break;
            case "danger":
                isObjectTag(other, "dangerbox");
                break;
            case "bad":
                isObjectTag(other, "badbox");
                break;
        }
    }

}
