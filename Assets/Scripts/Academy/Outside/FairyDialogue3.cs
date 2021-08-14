using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FairyDialogue3 : MonoBehaviour
{
    public static GameObject FairyDialogue, helloCard;
    void Start()
    {
        FairyDialogue = GameObject.Find("Fairy Dialogue 3");
        FairyDialogue.SetActive(false);

        helloCard = GameObject.Find("HELLO");
        helloCard.SetActive(false);
    }

    public void OnMouseDown()
    {
        FairyDialogue.SetActive(false);

        if (!helloCard.activeSelf & !Progress.hello)
            SoundManagerScript.playHELLOWordSound();
        if (Progress.hello == false)
            helloCard.SetActive(true);
    }
}
