using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door_UI : Block
{
    Transform playerPosition;
    protected override void OnMouseUp()
    {
        playerPosition = GameObject.Find("Player").transform;

        // Academy
        if (sceneName == "Academy")
        {
            if (Mathf.Abs(transform.position.x - targetBlock[0].position.x) <= 0.5f &&
                         Mathf.Abs(transform.position.y - targetBlock[0].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[0].position.x, targetBlock[0].position.y);
                SceneManager.LoadScene("Outside Academy");
            }
            else if (Mathf.Abs(transform.position.x - targetBlock[1].position.x) <= 0.5f &&
              Mathf.Abs(transform.position.y - targetBlock[1].position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlock[1].position.x, targetBlock[1].position.y);
                DoorOpen.OpenDoor();
                transform.position = new Vector2(playerPosition.position.x + initialPosition.x, playerPosition.position.y + initialPosition.y);
            }
            else
            {
                for (int i = 0; i < targetBlocks.Length; i++)
                {
                    if (Mathf.Abs(transform.position.x - targetBlocks[i].transform.position.x) <= 0.5f &&
                              Mathf.Abs(transform.position.y - targetBlocks[i].transform.position.y) <= 0.5f)
                        Progress.emotion++;
                }

                transform.position = new Vector2(playerPosition.position.x + 4.382f, playerPosition.position.y + 3.119f);
            }
        }
        // Outside Academy
        if (sceneName == "Outside Academy")
        {
            if (Mathf.Abs(transform.position.x - targetBlockSingle.position.x) <= 0.5f &&
                                Mathf.Abs(transform.position.y - targetBlockSingle.position.y) <= 0.5f)
            {
                transform.position = new Vector2(targetBlockSingle.position.x, targetBlockSingle.position.y);
                SceneManager.LoadScene("Academy");
                Progress.previousScene = "Outside Academy";
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

                transform.position = new Vector2(playerPosition.position.x + 4.382f, playerPosition.position.y + 3.119f);
            }
        }
    }
}
