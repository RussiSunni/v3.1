using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearBlock : Block
{

    protected override void OnMouseUp()
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


    // doubleclick
    private IEnumerator DoubleClickDetection()
    {
        coroutineAllowed = false;

        while (Time.time < firstClickTime + timeBetweenClicks)
        {
            if (clickCounter == 2)
            {

                SoundManagerScript.playBEARWordSound();

            }
            yield return new WaitForEndOfFrame();
        }
        clickCounter = 0;
        firstClickTime = 0f;
        coroutineAllowed = true;
    }
}
