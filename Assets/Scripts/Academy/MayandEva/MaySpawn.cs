using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaySpawn : MonoBehaviour
{
    private GameObject mayCard;
    void Start()
    {
        mayCard = GameObject.Find("MAY");
        mayCard.SetActive(false);
    }
    private void OnMouseDown()
    {
        SoundManagerScript.playMAYWordSound();
        if (Progress.may == false)
            mayCard.SetActive(true);
    }
}
