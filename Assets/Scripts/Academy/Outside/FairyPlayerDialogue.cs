using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FairyPlayerDialogue : MonoBehaviour
{
    public static bool answer;
    public static GameObject PlayerDialogueBox;
    private Sprite victorianDialogue, naDialogue, chineseDialogue, saDialogue;
    private SpriteRenderer rend;
    void Start()
    {
        PlayerDialogueBox = GameObject.Find("Player Dialogue");
        PlayerDialogueBox.SetActive(false);

        victorianDialogue = Resources.Load<Sprite>("Global/Dialogue/Victorian dialogue");
        naDialogue = Resources.Load<Sprite>("Global/Dialogue/North African dialogue");
        rend = GetComponent<SpriteRenderer>();
        if (Progress.playerCharacter == "English")
            rend.sprite = victorianDialogue;

        else if (Progress.playerCharacter == "North African")
            rend.sprite = naDialogue;
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
            FairyDialogue.DisplayDialogueOff();


            //  SoundManagerScript.playCorrectSound();

            Hello_UI.ReturnToInitialPosition();

            FairyDialogue04.DisplayDialogue();

        }
    }
}
