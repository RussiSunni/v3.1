using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sue_UI : Block
{
    public static Transform playerPosition, cardPosition;
    static bool suelocked;
    protected override void OnMouseUp()
    {
        cardPosition = this.transform;
        playerPosition = GameObject.Find("Player").transform;


        if (Mathf.Abs(transform.position.x - targetBlockSingle.position.x) <= 0.5f &&
                                        Mathf.Abs(transform.position.y - targetBlockSingle.position.y) <= 0.5f)
        {
            transform.position = new Vector2(targetBlockSingle.position.x, targetBlockSingle.position.y);
            suelocked = true;
            SuePlayerDialogue.answer++;
            Progress.exp++;
        }
        else
        {
            for (int i = 0; i < targetBlocks.Length; i++)
            {
                if (Mathf.Abs(transform.position.x - targetBlocks[i].transform.position.x) <= 0.5f &&
                          Mathf.Abs(transform.position.y - targetBlocks[i].transform.position.y) <= 0.5f)
                    Progress.emotion++;
            }

            transform.position = new Vector2(playerPosition.position.x + 4.382f, playerPosition.position.y + -1.874f);
        }
    }

    public static void ReturnToInitialPosition()
    {
        suelocked = false;
        cardPosition.position = new Vector2(playerPosition.position.x + 4.382f, playerPosition.position.y + -1.874f);
    }

    protected override void Update()
    {
        if (suelocked)
        {
            transform.position = new Vector2(targetBlockSingle.position.x, targetBlockSingle.position.y);
        }
    }
}

