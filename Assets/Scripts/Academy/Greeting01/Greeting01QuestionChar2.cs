using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Greeting01QuestionChar2 : MonoBehaviour
{

    public static SpriteRenderer rend;
    public static Sprite question3;

    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        question3 = Resources.Load<Sprite>("academy/02");
    }

    void Update()
    {
        if (Next.slideNumber == 3)
        {
            rend.sprite = question3;
        }
    }
}
