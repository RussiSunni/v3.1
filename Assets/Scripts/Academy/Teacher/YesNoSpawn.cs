using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YesNoSpawn : MonoBehaviour
{
    public static GameObject yes, no;

    void Start()
    {
        yes = GameObject.Find("YES");
        no = GameObject.Find("NO");
        yes.SetActive(false);
        no.SetActive(false);
    }

    public static void DisplayBlocks()
    {
        yes.SetActive(true);
        no.SetActive(true);
    }
}

