using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TeacherDialogue3 : MonoBehaviour
{
    public static GameObject TeacherDialogueBox;
    void Start()
    {
        TeacherDialogueBox = GameObject.Find("Teacher Dialogue 3");
        TeacherDialogueBox.SetActive(false);
    }

    public static void DisplayDialogue()
    {
        TeacherDialogueBox.SetActive(true);
    }

    public static void DisplayDialogueOff()
    {
        TeacherDialogueBox.SetActive(false);
    }

    public void OnMouseDown()
    {
        DisplayDialogueOff();

        //SecretaryDialogue2.DisplayDialogue();
        //Hello_UI.ReturnToInitialPosition();
    }
}
