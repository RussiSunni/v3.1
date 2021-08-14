using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No_UI : Block
{
    public static Transform playerPosition, cardPosition;

    protected override void OnMouseUp()
    {
        playerPosition = GameObject.Find("Player").transform;
        cardPosition = this.transform;

        if (Mathf.Abs(transform.position.x - targetBlock[0].position.x) <= 0.5f &&
                                    Mathf.Abs(transform.position.y - targetBlock[0].position.y) <= 0.5f)
        {
            Debug.Log("No");
        }
        else
        {
            transform.position = new Vector2(playerPosition.position.x + 3.133f, playerPosition.position.y + -4.378f);
        }
    }
}