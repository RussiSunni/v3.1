using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelloCard : MonoBehaviour
{
    public Image helloCard;
    void OnCollisionEnter2D(Collision2D col)
    {
        SoundManagerScript.playCorrectSound();
        this.gameObject.SetActive(false);
        Progress.hello = true;
        // SpellBookUI.Hello();

        helloCard.GetComponent<CanvasGroup>().alpha = 1;
        helloCard.GetComponent<CanvasGroup>().interactable = true;
    }
}
