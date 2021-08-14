using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ReadCard : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        SoundManagerScript.playCorrectSound();
        this.gameObject.SetActive(false);
        Progress.read = true;
        SpellBookUI.Read();
    }
}
