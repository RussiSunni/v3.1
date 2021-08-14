using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MayDialogue : MonoBehaviour
{
    public static GameObject MayDialogueBox;
    void Start()
    {
        MayDialogueBox = GameObject.Find("May Dialogue");
        MayDialogueBox.SetActive(false);
    }

    public static void DisplayDialogue()
    {
        MayDialogueBox.SetActive(true);
    }

    public static void DisplayDialogueOff()
    {
        MayDialogueBox.SetActive(false);
    }

    public void OnMouseDown()
    {
        MayPlayerDialogue.DisplayDialogue();
        DisplayDialogueOff();
        Hi_UI.hiLocked01 = false;
        Hi_UI.hiLocked02 = false;
        Hi_UI.ReturnToInitialPosition();
    }
}
