using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCard : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        //SoundManagerScript.playSpell01Sound();
        this.gameObject.SetActive(false);
        Progress.hello = true;
        SpellBookUI.Hello();


    }
}
