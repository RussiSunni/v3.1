using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hello_UI : Block
{
    public static bool suelocked, fairyLocked;
    public static Transform playerPosition, cardPosition;

    protected override void OnMouseUp()
    {
        playerPosition = GameObject.Find("Player").transform;
        cardPosition = this.transform;

        //Academy --------------------------------------
        if (sceneName == "Academy")
        {
            if (Mathf.Abs(transform.position.x - targetBlock[0].position.x) <= 0.5f &&
                                 Mathf.Abs(transform.position.y - targetBlock[0].position.y) <= 0.5f)
            {
                // transform.position = new Vector2(-7.154f, 3.946f);
                SecretaryDialogue.DisplayDialogue();
                Progress.exp++;
            }
            else if (Mathf.Abs(transform.position.x - targetBlock[1].position.x) <= 0.5f &&
                        Mathf.Abs(transform.position.y - targetBlock[1].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[1].position.x, targetBlock[1].position.y);
                SueDialogue.DisplayDialogue();
                suelocked = true;
                Progress.exp++;
            }
            else if (Mathf.Abs(transform.position.x - targetBlock[2].position.x) <= 0.5f &&
                       Mathf.Abs(transform.position.y - targetBlock[2].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[2].position.x, targetBlock[2].position.y);
                SuePlayerDialogue.answer++;
                suelocked = true;
                Progress.exp++;
            }
            else if (Mathf.Abs(transform.position.x - targetBlock[3].position.x) <= 0.5f &&
                       Mathf.Abs(transform.position.y - targetBlock[3].position.y) <= 0.5f)
            {
                transform.position = new Vector2(playerPosition.position.x + 4.382f, playerPosition.position.y + 1.875f);
                EvaDialogue_Hello.DisplayDialogue();
            }
            else if (Mathf.Abs(transform.position.x - targetBlock[4].position.x) <= 0.5f &&
                      Mathf.Abs(transform.position.y - targetBlock[4].position.y) <= 0.5f)
            {
                transform.position = new Vector2(playerPosition.position.x + 4.382f, playerPosition.position.y + 1.875f);
                MayDialogue_Hello.DisplayDialogue();
            }
            else if (Mathf.Abs(transform.position.x - targetBlockSingle.position.x) <= 0.5f &&
                    Mathf.Abs(transform.position.y - targetBlockSingle.position.y) <= 0.5f)
            {
                TeacherDialogue1.DisplayDialogue();
            }
            else
            {
                for (int i = 0; i < targetBlocks.Length; i++)
                {
                    if (Mathf.Abs(transform.position.x - targetBlocks[i].transform.position.x) <= 0.5f &&
                              Mathf.Abs(transform.position.y - targetBlocks[i].transform.position.y) <= 0.5f)
                        Progress.emotion++;
                }

                transform.position = new Vector2(playerPosition.position.x + 4.382f, playerPosition.position.y + 1.875f);
            }
        }

        // Ouside Academy --------------------------------------
        if (sceneName == "Outside Academy")
        {
            if (Mathf.Abs(transform.position.x - targetBlock[0].position.x) <= 0.5f &&
                                            Mathf.Abs(transform.position.y - targetBlock[0].position.y) <= 0.5f)
            {
                if (!Progress.door)
                {
                    FairyDialogue.DisplayDialogue();
                    fairyLocked = true;
                }
                else
                {
                    FairyDialogue.DisplayDialogue2();
                    transform.position = new Vector2(playerPosition.position.x + 4.382f, playerPosition.position.y + 1.875f);
                }
                Progress.exp++;

            }
            else if (Mathf.Abs(transform.position.x - targetBlock[1].position.x) <= 0.5f &&
                                           Mathf.Abs(transform.position.y - targetBlock[1].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[1].position.x, targetBlock[1].position.y);
                FairyPlayerDialogue.answer = true;
                locked = true;
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

                transform.position = new Vector2(playerPosition.position.x + 4.382f, playerPosition.position.y + 1.875f);
            }
        }

        // Ouside Academy --------------------------------------
        if (sceneName == "Forest")
        {
            if (Mathf.Abs(transform.position.x - targetBlock[0].position.x) <= 0.5f &&
                                                       Mathf.Abs(transform.position.y - targetBlock[0].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[0].position.x, targetBlock[0].position.y);
                SceneManager.LoadScene("ArtemisIntro");
            }
            else
            {
                transform.position = new Vector2(playerPosition.position.x + 4.382f, playerPosition.position.y + 1.875f);
            }
        }
    }
    public static void ReturnToInitialPosition()
    {
        locked = false;
        suelocked = false;
        cardPosition.position = new Vector2(playerPosition.position.x + 4.382f, playerPosition.position.y + 1.875f);
    }

    protected override void Update()
    {
        if (sceneName == "Outside Academy")
        {
            if (locked)
            {
                transform.position = new Vector2(-3.907827f, 3.307083f);
            }

            if (fairyLocked)
            {
                transform.position = new Vector2(4.8356f, 0.7238209f);
            }
        }
        if (sceneName == "Academy")
        {
            if (suelocked & SuePlayerDialogue.answer == 0)
            {
                transform.position = new Vector2(targetBlock[1].position.x, targetBlock[1].position.y);
            }
            else if (suelocked)
            {
                transform.position = new Vector2(targetBlock[2].position.x, targetBlock[2].position.y);
            }
        }
    }
}

