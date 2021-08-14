using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EvaDialogue2 : MonoBehaviour
{
    public static GameObject EvaDialogueBox;
    void Start()
    {
        EvaDialogueBox = this.gameObject;
        EvaDialogueBox.SetActive(false);
    }

    public static void DisplayDialogue()
    {
        EvaDialogueBox.SetActive(true);
    }

    public static void DisplayDialogueOff()
    {
        EvaDialogueBox.SetActive(false);
    }

    public void OnMouseDown()
    {
        DisplayDialogueOff();
        SoundManagerScript.playCorrectSound();
        GoodbyeSpawn.MakeActive();
    }
}
