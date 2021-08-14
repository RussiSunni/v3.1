using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TeacherDialogue2 : MonoBehaviour
{
    public static GameObject TeacherDialogueBox;
    void Start()
    {
        TeacherDialogueBox = GameObject.Find("Teacher Dialogue 2");
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
        YesNoSpawn.DisplayBlocks();
        TeacherDialogue3.DisplayDialogue();
    }
}
