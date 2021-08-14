using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleProgress : MonoBehaviour
{
    void Start()
    {
        //animals
        PlayerPrefs.SetInt("cat", 0);
        PlayerPrefs.SetInt("dog", 0);
        PlayerPrefs.SetInt("horse", 0);
        PlayerPrefs.SetInt("bear", 0);
        PlayerPrefs.SetInt("wolf", 0);
        PlayerPrefs.SetInt("zebra", 0);
        PlayerPrefs.SetInt("owl", 0);
        PlayerPrefs.SetInt("monkey", 0);
        PlayerPrefs.SetInt("squirrel", 0);
        PlayerPrefs.SetInt("giraffe", 0);
        PlayerPrefs.SetInt("lion", 0);
        PlayerPrefs.SetInt("alligator", 0);
        PlayerPrefs.SetInt("rhinoceros", 0);
        PlayerPrefs.SetInt("duck", 0);
        PlayerPrefs.SetInt("pig", 0);
        PlayerPrefs.SetInt("donkey", 0);
        PlayerPrefs.SetInt("rabbit", 0);
        PlayerPrefs.SetInt("frog", 0);
        PlayerPrefs.SetInt("tiger", 0);
        PlayerPrefs.SetInt("goat", 0);
        PlayerPrefs.SetInt("chicken", 0);
        PlayerPrefs.SetInt("elephant", 0);
        PlayerPrefs.SetInt("iguana", 0);

        //family
        PlayerPrefs.SetInt("sister", 0);
        PlayerPrefs.SetInt("mother", 0);
        PlayerPrefs.SetInt("family", 0);

        //verbs
        PlayerPrefs.SetInt("reading", 0);
        PlayerPrefs.SetInt("think", 0);
        PlayerPrefs.SetInt("sleep", 0);
        PlayerPrefs.SetInt("wake up", 0);
        PlayerPrefs.SetInt("deliver", 0);
        PlayerPrefs.SetInt("mobile phone", 0);
    }
}
