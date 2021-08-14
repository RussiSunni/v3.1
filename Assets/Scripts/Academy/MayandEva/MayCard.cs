using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayCard : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        SoundManagerScript.playCorrectSound();
        this.gameObject.SetActive(false);
        Progress.may = true;
        SpellBookUI.May();
    }
}
