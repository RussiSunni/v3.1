using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FairyExerciseText : MonoBehaviour
{
    Text fairyText;

    void Start()
    {
        fairyText = GetComponent<Text>();
        fairyText.text = "Now, pay attention. \n \r  These are the spells you will start with.";
    }

    // Update is called once per frame
    void Update()
    {
        if (FairyNext.questionNumber == 27)
        {
            fairyText.text = "They will be stored in your book.";
        }
    }
}
