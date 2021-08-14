using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zebra : MonoBehaviour
{
    public GameObject zebraCard;

    void Start()
    {
        // bearCard = GameObject.Find("Bear Card");
    }
    private void OnMouseDown()
    {
        // SoundManagerScript.playZEBRAWordSound();
        // ForestScript.ZebraActive();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        SceneManager.LoadScene("Zebra");
    }
}