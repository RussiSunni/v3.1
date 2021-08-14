using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SueDialogue : MonoBehaviour
{
    public static GameObject SueDialogueBox, sueCard;
    void Start()
    {
        SueDialogueBox = GameObject.Find("Sue Dialogue");
        SueDialogueBox.SetActive(false);

        sueCard = GameObject.Find("SUE");
        sueCard.SetActive(false);
    }

    public static void DisplayDialogue()
    {
        SueDialogueBox.SetActive(true);

        if (Progress.sue == false)
        {
            sueCard.SetActive(true);
            SoundManagerScript.playSUEWordSound();
        }
    }

    public static void DisplayDialogueOff()
    {
        SueDialogueBox.SetActive(false);
    }

    public void OnMouseDown()
    {
        SuePlayerDialogue.DisplayDialogue();
        DisplayDialogueOff();
        Hello_UI.suelocked = false;
        Hello_UI.ReturnToInitialPosition();
    }
}
