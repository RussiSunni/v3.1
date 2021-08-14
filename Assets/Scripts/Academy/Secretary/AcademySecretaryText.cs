using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AcademySecretaryText : MonoBehaviour
{
    public static Text secretaryText;

    void Start()
    {
        secretaryText = GetComponent<Text>();

        if (Progress.lettersExerciseComplete == false)
        {
            secretaryText.text = "";
        }
        else if (Progress.nameExerciseComplete == false)
        {
            secretaryText.text = "Please come and see me when you have a chance.";
        }
        else
        {
            secretaryText.text = "";
        }
    }
}




