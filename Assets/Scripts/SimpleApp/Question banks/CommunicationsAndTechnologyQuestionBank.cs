using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommunicationsAndTechnologyQuestionBank : SimpleQuestion
{
    SimpleQuestion communicationsAndTechnology001 = new SimpleQuestion()
    {
        number = 1,
        questionName = "mobile phone",
        sprite = Resources.Load<Sprite>("SimpleApp/Questions/Mobile phone"),
        answerOptions = new List<string>()
        {
            "sister",
            "brother",
            "family",
            "mobile phone"
        },
        tags = new List<string>()
        {
            "Communications and Technology"
        },
        size = 2
    };

    // questions.Add(communicationsAndTechnology001);
}