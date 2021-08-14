using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YesCard : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        SoundManagerScript.playCorrectSound();
        this.gameObject.SetActive(false);
        Progress.yes = true;
        SpellBookUI.Yes();
    }
}
