using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Greeting01QuestionText : MonoBehaviour
{

    Text text;

    private void Start()
    {
        text = GetComponent<Text>();
        text.text = "What do you want, loser?";
    }

    void Update()
    {

        if (Next.slideNumber == 2)
        {
            text.text = "Yeah, your English sucks.";
        }
        if (Next.slideNumber == 3)
        {
            text.text = "";
        }
    }
}
