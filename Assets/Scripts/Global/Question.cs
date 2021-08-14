using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Question : MonoBehaviour
{
    private SpriteRenderer rend;
    private Sprite question1, question2, question3, question4, question5;
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        question1 = Resources.Load<Sprite>("cat");
        question2 = Resources.Load<Sprite>("dog");
        question3 = Resources.Load<Sprite>("owl");
        question4 = Resources.Load<Sprite>("bear");
        question5 = Resources.Load<Sprite>("wolf");
        rend.sprite = question1;
    }

    // Update is called once per frame
    void Update()
    {
        if (TestExerciseNext.catFlag)
        {
            rend.sprite = question2;
        }

        if (TestExerciseNext.dogFlag)
        {
            rend.sprite = question3;
        }

        if (TestExerciseNext.owlFlag)
        {
            rend.sprite = question4;
        }

        if (TestExerciseNext.bearFlag)
        {
            rend.sprite = question5;
        }
    }
}
