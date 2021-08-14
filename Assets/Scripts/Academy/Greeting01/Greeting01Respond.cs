using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Greeting01Respond : MonoBehaviour
{
    GameObject hello, hi, good_day, targetBlock;

    private void Start()
    {
        hello = GameObject.Find("hello");
        hi = GameObject.Find("hi");
        good_day = GameObject.Find("good day");
        targetBlock = GameObject.Find("TargetBlock");
        hello.SetActive(false);
        hi.SetActive(false);
        good_day.SetActive(false);
        targetBlock.SetActive(false);
    }
    public void RespondButton()
    {
        hello.SetActive(true);
        hi.SetActive(true);
        good_day.SetActive(true);
        targetBlock.SetActive(false);
    }
}







