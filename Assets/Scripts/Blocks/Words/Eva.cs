using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eva : Block
{
    public static bool correctPosition = false;
    protected override void OnMouseUp()
    {
        if (Mathf.Abs(transform.position.x - targetBlock[1].position.x) <= 0.5f &&
                             Mathf.Abs(transform.position.y - targetBlock[1].position.y) <= 0.5f)
        {
            transform.position = new Vector2(targetBlock[1].position.x, targetBlock[1].position.y);
            SoundManagerScript.playCorrectSound();
            correctPosition = true;
        }
        else
        {
            transform.position = new Vector2(initialPosition.x, initialPosition.y);
        }
    }
}

