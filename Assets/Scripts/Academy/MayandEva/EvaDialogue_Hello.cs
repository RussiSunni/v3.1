using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EvaDialogue_Hello : MonoBehaviour
{
    public static GameObject DialogueBox;
    void Start()
    {
        DialogueBox = GameObject.Find("Eva Dialogue (Hello)");
        DialogueBox.SetActive(false);
    }

    public static void DisplayDialogue()
    {
        DialogueBox.SetActive(true);
    }

    public static void DisplayDialogueOff()
    {
        DialogueBox.SetActive(false);
    }

    public void OnMouseDown()
    {
        DisplayDialogueOff();
    }
}
