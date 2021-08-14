using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SecretaryDialogue : MonoBehaviour
{
    public static GameObject SecretaryDialogueBox;
    void Start()
    {
        SecretaryDialogueBox = GameObject.Find("Secretary Dialogue");
        SecretaryDialogueBox.SetActive(false);
    }

    public static void DisplayDialogue()
    {
        SecretaryDialogueBox.SetActive(true);
    }

    public static void DisplayDialogueOff()
    {
        SecretaryDialogueBox.SetActive(false);
    }

    public void OnMouseDown()
    {
        DisplayDialogueOff();
        SecretaryDialogue2.DisplayDialogue();
        Hello_UI.ReturnToInitialPosition();
    }
}
