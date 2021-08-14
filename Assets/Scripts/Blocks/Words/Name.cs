using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Name : MonoBehaviour
{
    Transform targetBlock;
    private Vector2 initialPosition, mousePosition;
    private float deltaX, deltaY;
    void Start()
    {
        initialPosition = transform.position;
        targetBlock = GameObject.Find("TargetBlock").transform;
    }

    private void OnMouseDown()
    {
        deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
        deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
    }

    private void OnMouseDrag()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(mousePosition.x - deltaX, mousePosition.y - deltaY);
    }

    private void OnMouseUp()
    {
        if (Mathf.Abs(transform.position.x - targetBlock.position.x) <= 0.5f &&
                             Mathf.Abs(transform.position.y - targetBlock.position.y) <= 0.5f)
        {
            transform.position = new Vector2(targetBlock.position.x, targetBlock.position.y);
        }
        else
        {
            transform.position = new Vector2(initialPosition.x, initialPosition.y);
        }
    }
}

