using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayPlayerDialogue : MonoBehaviour
{
    public static int answer;
    public static GameObject PlayerDialogueBox, PlayerDialogueBox2;
    void Start()
    {
        PlayerDialogueBox = GameObject.Find("May Player Dialogue");
        PlayerDialogueBox2 = GameObject.Find("May Player Dialogue 2");
        PlayerDialogueBox.SetActive(false);
        PlayerDialogueBox2.SetActive(false);
    }

    public static void DisplayDialogue()
    {
        PlayerDialogueBox.SetActive(true);
    }

    public static void DisplayDialogueOff()
    {
        PlayerDialogueBox.SetActive(false);
    }

    public static void DisplayDialogue2()
    {
        PlayerDialogueBox2.SetActive(true);
    }

    private void OnMouseDown()
    {
        if (answer == 2)
        {
            PlayerDialogueBox.SetActive(false);

            Hi_UI.ReturnToInitialPosition();
            May_UI.ReturnToInitialPosition();
            MayDialogue2.DisplayDialogue();
        }
    }
}
