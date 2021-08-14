using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FairyDialogue2 : MonoBehaviour
{
    public static GameObject FairyDialogueBox2;
    void Start()
    {
        FairyDialogueBox2 = GameObject.Find("Fairy Dialogue 2");
    }

    public void OnMouseDown()
    {
        FairyDialogueBox2.SetActive(false);
        HiSpawn.MakeActive();
    }
}
