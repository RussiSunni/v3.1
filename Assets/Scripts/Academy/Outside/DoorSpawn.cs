using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSpawn : MonoBehaviour
{
    public static GameObject doorCard;
    void Start()
    {
        doorCard = GameObject.Find("DOOR");
        doorCard.SetActive(false);
    }
    // private void OnMouseDown()
    // {
    //     if (!doorCard.activeSelf & !Progress.door)
    //         SoundManagerScript.playDOORWordSound();
    //     if (Progress.door == false)
    //         doorCard.SetActive(true);
    // }

    public static void MakeActive()
    {
        if (Progress.door == false)
        {
            SoundManagerScript.playDOORWordSound();
            doorCard.SetActive(true);
        }
    }
}