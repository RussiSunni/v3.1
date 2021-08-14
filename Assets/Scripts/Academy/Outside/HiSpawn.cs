using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiSpawn : MonoBehaviour
{
    public static GameObject hiCard;
    void Start()
    {
        hiCard = GameObject.Find("HI");
        hiCard.SetActive(false);
    }

    public static void MakeActive()
    {
        if (Progress.hi == false)
        {
            SoundManagerScript.playHIWordSound();
            hiCard.SetActive(true); 
        }
    }
}