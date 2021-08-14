using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GoodbyeCard : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        SoundManagerScript.playCorrectSound();
        this.gameObject.SetActive(false);
        Progress.goodbye = true;
        SpellBookUI.Goodbye();
    }
}
