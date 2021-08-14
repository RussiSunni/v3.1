using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestScript : MonoBehaviour
{
    public static GameObject bearCard, monkeyCard;

    void Start()
    {
        bearCard = GameObject.Find("Bear Card");
        bearCard.SetActive(false);
        monkeyCard = GameObject.Find("Monkey Card");
        monkeyCard.SetActive(false);
    }

    public static void BearActive()
    {
        bearCard.SetActive(true);
    }
    public static void MonkeyActive()
    {
        monkeyCard.SetActive(true);
    }
}
