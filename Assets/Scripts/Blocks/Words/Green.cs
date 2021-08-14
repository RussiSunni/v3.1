using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green : Block
{

    void OnCollisionEnter2D(Collision2D col)
    {
        SoundManagerScript.playCorrectSound();
        this.gameObject.SetActive(false);
        Progress.green = true;
    }
}
