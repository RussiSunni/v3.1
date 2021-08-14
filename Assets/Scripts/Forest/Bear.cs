using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : MonoBehaviour
{
    public GameObject bearCard;

    void Start()
    {
        bearCard = GameObject.Find("Bear Card");
    }
    private void OnMouseDown()
    {
        SoundManagerScript.playBEARWordSound();
        ForestScript.BearActive();
    }
}