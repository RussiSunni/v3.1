using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FairyDialogue05 : MonoBehaviour
{
    public static GameObject FairyDialogue;
    void Start()
    {
        FairyDialogue = GameObject.Find("Fairy Dialogue 5");
        FairyDialogue.SetActive(false);
    }

    public static void DisplayDialogue()
    {
        FairyDialogue.SetActive(true);
    }

    public void OnMouseDown()
    {
        FairyDialogue.SetActive(false);
        DoorSpawn.MakeActive();
    }
}
