using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatCard : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        SoundManagerScript.playCorrectSound();
        this.gameObject.SetActive(false);
        Progress.cat = true;
        SpellBookUI.Sue();
    }
}
