using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SecretaryDialogue2 : MonoBehaviour
{
    public static GameObject SecretaryDialogueBox2, readCard;
    void Start()
    {
        SecretaryDialogueBox2 = GameObject.Find("Secretary Dialogue 2");
        SecretaryDialogueBox2.SetActive(false);

        readCard = GameObject.Find("READ");
        readCard.SetActive(false);
    }

    public static void DisplayDialogue()
    {
        SecretaryDialogueBox2.SetActive(true);
    }

    public static void DisplayDialogueOff()
    {
        SecretaryDialogueBox2.SetActive(false);
    }

    public void OnMouseDown()
    {
        DisplayDialogueOff();

        if (Progress.read == false)
        {
            SoundManagerScript.playREADWordSound();
            readCard.SetActive(true);
        }
    }
}
