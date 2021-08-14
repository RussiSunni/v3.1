using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf : MonoBehaviour
{
    private Vector2 initialPosition;
    private Vector2 mousePosition;
    private float deltaX, deltaY;
    public static bool locked;


    // doubleclick
    private float firstClickTime, timeBetweenClicks;
    private bool coroutineAllowed, wordShowing;
    private int clickCounter;
    public static SpriteRenderer rend;
    public static Sprite word, picture;


    void Start()
    {
        initialPosition = transform.position;
        locked = false;

        // doubleclick
        firstClickTime = 0f;
        timeBetweenClicks = 0.3f;
        clickCounter = 0;
        coroutineAllowed = true;
        rend = GetComponent<SpriteRenderer>();
        word = Resources.Load<Sprite>("WOLFWord");
        picture = Resources.Load<Sprite>("WOLFPicture");
        rend.sprite = word;
        wordShowing = true;
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
    }

    // doubleclick
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
            clickCounter += 1;

        if (clickCounter == 1 && coroutineAllowed)
        {
            firstClickTime = Time.time;
            StartCoroutine(DoubleClickDetection());
        }
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
                    rend.sprite = picture;
                    SoundManagerScript.playWOLFWordSound();
                }
                else
                {
                    wordShowing = true;
                    rend.sprite = word;
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
