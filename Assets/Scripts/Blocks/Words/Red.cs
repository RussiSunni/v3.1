using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : Block
{

    void OnCollisionEnter2D(Collision2D col)
    {
        SoundManagerScript.playCorrectSound();
        this.gameObject.SetActive(false);
        Progress.red = true;
    }
}
