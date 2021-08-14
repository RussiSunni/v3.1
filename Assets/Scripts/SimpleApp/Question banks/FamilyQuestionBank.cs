using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamilyQuestionBank : SimpleQuestion
{
    SimpleQuestion family001 = new SimpleQuestion()
    {
        number = 1,
        questionName = "sister",
        sprite = Resources.Load<Sprite>("SimpleApp/Questions/Sister"),
        answerOptions = new List<string>()
        {
            "sister",
            "brother",
            "mother",
            "father"
        },
        tags = new List<string>()
        {
            "family"
        },
        size = 2
    };

    //  questions.Add(family001);

    SimpleQuestion family002 = new SimpleQuestion()
    {
        number = 2,
        questionName = "mother",
        sprite = Resources.Load<Sprite>("SimpleApp/Questions/Mother"),
        answerOptions = new List<string>()
        {
            "sister",
            "brother",
            "mother",
            "father"
        },
        tags = new List<string>()
        {
            "family"
        },
        size = 2
    };

    //  questions.Add(family002);

    SimpleQuestion family003 = new SimpleQuestion()
    {
        number = 3,
        questionName = "family",
        sprite = Resources.Load<Sprite>("SimpleApp/Questions/Family"),
        answerOptions = new List<string>()
        {
            "sister",
            "brother",
            "family",
            "father"
        },
        tags = new List<string>()
        {
            "family"
        },
        size = 2
    };

    //  questions.Add(family003);
}