using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvaCard : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        SoundManagerScript.playCorrectSound();
        this.gameObject.SetActive(false);
        Progress.eva = true;
        SpellBookUI.Eva();
    }
}
