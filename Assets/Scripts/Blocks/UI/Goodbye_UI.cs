using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goodbye_UI : Block
{
    public static Transform playerPosition, cardPosition;
    public static bool goodbyeLocked;
    protected override void OnMouseUp()
    {
        cardPosition = this.transform;
        playerPosition = GameObject.Find("Player").transform;
        if (Mathf.Abs(transform.position.x - targetBlock[0].position.x) <= 0.5f &&
                                            Mathf.Abs(transform.position.y - targetBlock[0].position.y) <= 0.5f)
        {
            transform.position = new Vector2(targetBlock[0].position.x, targetBlock[0].position.y);
            goodbyeLocked = true;
            MayPlayerDialogue2.answer = true;
        }
        else
        {
            for (int i = 0; i < targetBlocks.Length; i++)
            {
                if (Mathf.Abs(transform.position.x - targetBlocks[i].transform.position.x) <= 0.5f &&
                          Mathf.Abs(transform.position.y - targetBlocks[i].transform.position.y) <= 0.5f)
                    Progress.emotion++;
            }

            transform.position = new Vector2(playerPosition.position.x + 4.382f, playerPosition.position.y + -4.378f);
        }
    }

    protected override void Update()
    {
        if (goodbyeLocked)
        {
            transform.position = new Vector2(targetBlock[0].position.x, targetBlock[0].position.y);
        }
    }

    public static void ReturnToInitialPosition()
    {
        locked = false;
        goodbyeLocked = false;
        cardPosition.position = new Vector2(playerPosition.position.x + 4.382f, playerPosition.position.y + -4.378f);
    }
}

