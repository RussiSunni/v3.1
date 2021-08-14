using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoCard : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        SoundManagerScript.playCorrectSound();
        this.gameObject.SetActive(false);
        Progress.no = true;
        SpellBookUI.No();
    }
}
