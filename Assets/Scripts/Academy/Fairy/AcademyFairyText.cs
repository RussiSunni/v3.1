using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AcademyFairyText : MonoBehaviour
{
    public static Text fairyText;

    void Start()
    {
        fairyText = GetComponent<Text>();

        if (Progress.lettersExerciseComplete == false)
        {
            fairyText.text = "Psst. Over here.";
        }
        else
        {
            fairyText.text = "Go get 'em, Tiger.";
        }
    }
}




