using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollSpawn : MonoBehaviour
{
    public static GameObject scroll;

    public static bool scrollDisplaying;
    void Start()
    {
        scroll = GameObject.Find("Scroll");
        scroll.SetActive(false);
        scrollDisplaying = false;
    }

    public static void DisplayScroll()
    {
        scroll.SetActive(true);
        scrollDisplaying = true;
    }

    public static void HideScroll()
    {
        scroll.SetActive(false);
        scrollDisplaying = false;
    }
}

