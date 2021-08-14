using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hi_UI : Block
{
    public static Transform playerPosition, cardPosition;
    public static bool hiLocked01, hiLocked02, hiLocked03, hiLocked04;
    protected override void OnMouseUp()
    {
        cardPosition = this.transform;
        playerPosition = GameObject.Find("Player").transform;
        if (Mathf.Abs(transform.position.x - targetBlock[0].position.x) <= 0.5f &&
                                            Mathf.Abs(transform.position.y - targetBlock[0].position.y) <= 0.5f)
        {
            transform.position = new Vector2(targetBlock[0].position.x, targetBlock[0].position.y);
            hiLocked01 = true;
            MayDialogue.DisplayDialogue();
        }
        else if (Mathf.Abs(transform.position.x - targetBlock[1].position.x) <= 0.5f &&
                                            Mathf.Abs(transform.position.y - targetBlock[1].position.y) <= 0.5f)
        {
            transform.position = new Vector2(targetBlock[1].position.x, targetBlock[1].position.y);
            MayPlayerDialogue.answer++;
            hiLocked02 = true;
        }
        else if (Mathf.Abs(transform.position.x - targetBlock[2].position.x) <= 0.5f &&
                                           Mathf.Abs(transform.position.y - targetBlock[2].position.y) <= 0.5f)
        {
            transform.position = new Vector2(targetBlock[2].position.x, targetBlock[2].position.y);
            hiLocked03 = true;
            EvaDialogue.DisplayDialogue();
        }
        else if (Mathf.Abs(transform.position.x - targetBlock[3].position.x) <= 0.5f &&
                                          Mathf.Abs(transform.position.y - targetBlock[3].position.y) <= 0.5f)
        {
            transform.position = new Vector2(targetBlock[3].position.x, targetBlock[3].position.y);
            EvaPlayerDialogue.answer++;
            hiLocked04 = true;
        }
        else if (Mathf.Abs(transform.position.x - targetBlock[4].position.x) <= 0.5f &&
                                         Mathf.Abs(transform.position.y - targetBlock[4].position.y) <= 0.5f)
        {
            transform.position = new Vector2(playerPosition.position.x + 4.382f, playerPosition.position.y + -3.132f);
            SueDialogue_Hi.DisplayDialogue();

        }

        else
        {
            for (int i = 0; i < targetBlocks.Length; i++)
            {
                if (Mathf.Abs(transform.position.x - targetBlocks[i].transform.position.x) <= 0.5f &&
                          Mathf.Abs(transform.position.y - targetBlocks[i].transform.position.y) <= 0.5f)
                    Progress.emotion++;
            }

            transform.position = new Vector2(playerPosition.position.x + 4.382f, playerPosition.position.y + -3.132f);
        }
    }

    public static void ReturnToInitialPosition()
    {
        hiLocked01 = false;
        hiLocked02 = false;
        hiLocked03 = false;
        hiLocked04 = false;
        cardPosition.position = new Vector2(playerPosition.position.x + 4.382f, playerPosition.position.y + -3.132f);
    }
    protected override void Update()
    {
        if (hiLocked01)
        {
            transform.position = new Vector2(targetBlock[0].position.x, targetBlock[0].position.y);
        }
        else if (hiLocked02)
        {
            transform.position = new Vector2(targetBlock[1].position.x, targetBlock[1].position.y);
        }
        else if (hiLocked03)
        {
            transform.position = new Vector2(targetBlock[2].position.x, targetBlock[2].position.y);
        }
        else if (hiLocked04)
        {
            transform.position = new Vector2(targetBlock[3].position.x, targetBlock[3].position.y);
        }
    }
}

