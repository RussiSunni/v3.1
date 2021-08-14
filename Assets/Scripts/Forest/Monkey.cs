using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monkey : MonoBehaviour
{
    public GameObject monkeyCard;

    void Start()
    {
        monkeyCard = GameObject.Find("Monkey Card");
    }
    private void OnMouseDown()
    {
        SoundManagerScript.playMONKEYWordSound();
        ForestScript.MonkeyActive();
    }
}