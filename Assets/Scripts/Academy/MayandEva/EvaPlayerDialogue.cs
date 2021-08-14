using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvaPlayerDialogue : MonoBehaviour
{
    public static int answer;
    public static GameObject PlayerDialogueBox;
    void Start()
    {
        PlayerDialogueBox = GameObject.Find("Eva Player Dialogue");
        PlayerDialogueBox.SetActive(false);
    }

    public static void DisplayDialogue()
    {
        PlayerDialogueBox.SetActive(true);
    }

    public static void DisplayDialogueOff()
    {
        PlayerDialogueBox.SetActive(false);
    }

    private void OnMouseDown()
    {
        if (answer == 2)
        {
            PlayerDialogueBox.SetActive(false);
            EvaDialogue.DisplayDialogueOff();

            Hi_UI.ReturnToInitialPosition();
            Eva_UI.ReturnToInitialPosition();
            EvaDialogue2.DisplayDialogue();
        }
    }
}
