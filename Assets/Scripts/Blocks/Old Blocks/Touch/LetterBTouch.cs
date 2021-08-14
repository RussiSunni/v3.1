using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterBTouch : MonoBehaviour
{


    private Vector2 initialPosition;

    private float deltaX, deltaY;

    public static bool locked;

    public static bool pressed;

    
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.touchCount > 0 && !locked)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:

                    if  (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                    {
                        deltaX = touchPos.x - transform.position.x;
                        deltaY = touchPos.y - transform.position.y;
                    }
                    break;

                case TouchPhase.Moved:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                    {
                        transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                        pressed = true;
                    }
                    break;


                case TouchPhase.Ended:

                    {
                        transform.position = new Vector2(initialPosition.x, initialPosition.y);
                    }
                    break;

            }
        }
    }
}
