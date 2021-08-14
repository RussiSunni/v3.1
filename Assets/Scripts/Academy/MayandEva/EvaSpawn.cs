using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvaSpawn : MonoBehaviour
{
    private GameObject evaCard;
    void Start()
    {
        evaCard = GameObject.Find("EVA");

        evaCard.SetActive(false);
    }
    private void OnMouseDown()
    {
        SoundManagerScript.playEVAWordSound();
        if (Progress.eva == false)
            evaCard.SetActive(true);
    }
}
