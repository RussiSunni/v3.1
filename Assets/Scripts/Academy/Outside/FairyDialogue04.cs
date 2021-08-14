using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FairyDialogue04 : MonoBehaviour
{
    public static GameObject FairyDialogue;
    void Start()
    {
        FairyDialogue = GameObject.Find("Fairy Dialogue 4");
        FairyDialogue.SetActive(false);
    }

    public static void DisplayDialogue()
    {
        FairyDialogue.SetActive(true);
    }
    public void OnMouseDown()
    {
        FairyDialogue.SetActive(false);
        FairyDialogue05.DisplayDialogue();
    }
}
