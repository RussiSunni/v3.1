using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeIntroText : MonoBehaviour
{
    Text introText;

    void Start()
    {
        introText = GetComponent<Text>();
        // introText.text = "Oh wonderful, a new student.";
        introText.text = "Hello child,\r\n Welcome to Sunshine English School.";
    }

    void Update()
    {
        if (IntroNextScene.numberPresses == 1)
        {
            introText.text = "This way, there is much to do.";
        }
    }
}

