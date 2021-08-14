using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FairyDialogue : MonoBehaviour
{
    public Text dialogueText;
    public Image dialogueImage, dialoguePanel;
    public static GameObject FairyDialogueBox, FairyDialogueBox2;
    public GameObject helloCard;
    void Start()
    {
        FairyDialogueBox = GameObject.Find("Fairy Dialogue");
        FairyDialogueBox.SetActive(false);

        FairyDialogueBox2 = GameObject.Find("Fairy Dialogue 2");
        FairyDialogueBox2.SetActive(false);

        helloCard.SetActive(false);
    }

    public static void DisplayDialogue()
    {
        FairyDialogueBox.SetActive(true);
    }

    public static void DisplayDialogueOff()
    {
        FairyDialogueBox.SetActive(false);
    }

    public static void DisplayDialogue2()
    {
        FairyDialogueBox2.SetActive(true);
    }


    public void OnMouseDown()
    {
        dialoguePanel.GetComponent<CanvasGroup>().alpha = 1;
        dialoguePanel.GetComponent<CanvasGroup>().interactable = true;


        // FairyPlayerDialogue.DisplayDialogue();
        // FairyDialogueBox.SetActive(false);
        // Hello_UI.fairyLocked = false;
        // Hello_UI.ReturnToInitialPosition();
    }


    public void NextButton()
    {
        if (!helloCard.activeSelf & !Progress.hello)
            SoundManagerScript.playHELLOWordSound();
        if (Progress.hello == false)
            helloCard.SetActive(true);

        dialoguePanel.GetComponent<CanvasGroup>().alpha = 0;
        dialoguePanel.GetComponent<CanvasGroup>().interactable = false;
    }
}
