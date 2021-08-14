using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class May : Block
{
    public static bool correctPosition = false;

    protected override void OnMouseUp()
    {
        if (Mathf.Abs(transform.position.x - targetBlock[0].position.x) <= 0.5f &&
                             Mathf.Abs(transform.position.y - targetBlock[0].position.y) <= 0.5f)
        {
            transform.position = new Vector2(targetBlock[0].position.x, targetBlock[0].position.y);
            SoundManagerScript.playCorrectSound();
            correctPosition = true;
        }
        else
        {
            transform.position = new Vector2(initialPosition.x, initialPosition.y);
        }
    }
}

