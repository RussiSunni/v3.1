using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MayDialogue2 : MonoBehaviour
{
    public static GameObject MayDialogueBox;
    void Start()
    {
        MayDialogueBox = this.gameObject;
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
        DisplayDialogueOff();
        MayPlayerDialogue.DisplayDialogue2();
    }
}
