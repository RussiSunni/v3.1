using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : Block
{
    protected override void OnMouseUp()
    {
        if (sceneName == "HelloExercise" || sceneName == "ArtemisHello")
        {
            if (Mathf.Abs(transform.position.x - targetBlockSingle.position.x) <= 0.5f &&
                                 Mathf.Abs(transform.position.y - targetBlockSingle.position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlockSingle.position.x, targetBlockSingle.position.y);
            }
        }
        else
        {
            transform.position = new Vector2(initialPosition.x, initialPosition.y);
        }
    }
}

