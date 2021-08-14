using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayPlayerDialogue2 : MonoBehaviour
{
    public static bool answer;
    public static GameObject PlayerDialogueBox;
    void Start()
    {
        PlayerDialogueBox = this.gameObject;
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
        if (answer)
        {
            PlayerDialogueBox.SetActive(false);
            Goodbye_UI.ReturnToInitialPosition();
            SoundManagerScript.playCorrectSound();
        }
    }
}
