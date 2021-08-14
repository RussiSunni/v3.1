using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagazineQuestion : MonoBehaviour
{
    public static SpriteRenderer rend;
    public static Sprite question1, question2, question3, question4;
    int questionNumber = 1;

    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        question1 = Resources.Load<Sprite>("academy/magazine01");
        question2 = Resources.Load<Sprite>("academy/magazine02");
        question3 = Resources.Load<Sprite>("academy/magazine03");
        question4 = Resources.Load<Sprite>("academy/magazine04");
        rend.sprite = question1;
    }

    public void ChangeQuestion()
    {
        questionNumber++;

        if (questionNumber == 2)
        {
            rend.sprite = question2;
        }
        else if (questionNumber == 3)
        {
            rend.sprite = question3;
        }
        else if (questionNumber == 4)
        {
            rend.sprite = question4;
        }
    }
}


