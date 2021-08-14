using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Greeting01Question : MonoBehaviour
{
    GameObject nextButton, respondButton, walkAwayButton;
    public static SpriteRenderer rend;
    public static Sprite question1, question2, question3;

    private void Start()
    {
        nextButton = GameObject.Find("NextButton");
        respondButton = GameObject.Find("RespondButton");
        walkAwayButton = GameObject.Find("BackButton");
        respondButton.SetActive(false);
        walkAwayButton.SetActive(false);

        rend = GetComponent<SpriteRenderer>();
        question1 = Resources.Load<Sprite>("academy/01");
        question2 = Resources.Load<Sprite>("academy/02");
        question3 = Resources.Load<Sprite>("academy/03");

        rend.sprite = question1;

    }

    void Update()
    {
        if (Next.slideNumber == 2)
        {
            rend.sprite = question2;
        }

        if (Next.slideNumber == 3)
        {
            rend.sprite = question1;
            nextButton.SetActive(false);
            respondButton.SetActive(true);
            walkAwayButton.SetActive(true);
        }
    }
}
