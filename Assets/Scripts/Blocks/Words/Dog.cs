using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{

    private Vector2 initialPosition, mousePosition;
    private float deltaX, deltaY;
    public static bool locked;

    // doubleclick
    private float firstClickTime, timeBetweenClicks;
    private bool coroutineAllowed, wordShowing;
    private int clickCounter;

    // rotation
    public Vector3 RotateStep = new Vector3(0, 180, 0);
    public float RotateSpeed = 5f;
    private Quaternion _targetRot = Quaternion.identity;


    void Start()
    {
        initialPosition = transform.position;
        locked = false;

        // doubleclick
        firstClickTime = 0f;
        timeBetweenClicks = 0.3f;
        clickCounter = 0;
        coroutineAllowed = true;
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
        transform.position = new Vector2(initialPosition.x, initialPosition.y);


        // doubleclick

        if (Input.GetMouseButtonUp(0))
            clickCounter += 1;

        if (clickCounter == 1 && coroutineAllowed)
        {
            firstClickTime = Time.time;
            StartCoroutine(DoubleClickDetection());
        }
    }

    void Update()
    {
        // rotate
        transform.rotation = Quaternion.Lerp(transform.rotation, _targetRot, RotateSpeed * Time.deltaTime);
    }

    // doubleclick
    private IEnumerator DoubleClickDetection()
    {
        coroutineAllowed = false;

        while (Time.time < firstClickTime + timeBetweenClicks)
        {
            if (clickCounter == 2)
            {
                if (wordShowing)
                {
                    wordShowing = false;
                    _targetRot *= Quaternion.Euler(RotateStep);
                    SoundManagerScript.playDOGWordSound();
                }
                else
                {
                    wordShowing = true;
                }
                break;
            }
            yield return new WaitForEndOfFrame();
        }
        clickCounter = 0;
        firstClickTime = 0f;
        coroutineAllowed = true;
    }
}
